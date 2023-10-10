using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DocumentBuilder.Components;
using DocumentBuilder.Debug;
using DocumentBuilder.Export;
using DocumentBuilder.FileManagement;

namespace DocumentBuilder.Forms
{
    internal partial class Form_Export : Form
    {
        // Document that is going to be exported.
        public Document document;

        // Active instance of form.
        private static Form_Export activeExportForm = null;

        // Last folder that was exported to (in current session).
        public static string lastExportLocation = null;

        /// <summary>
        /// Form constructor.
        /// </summary>
        public Form_Export(Document document)
        {
            InitializeComponent();

            this.document = document;

            // Add pages to check list, if document is not null.
            if (document != null)
            {
                for (int i = 0; i < document.pages.Count; i++)
                {
                    CheckList_ExportPages.Items.Add($"Page {i + 1}");

                    // Check all pages by default.
                    CheckList_ExportPages.SetItemChecked(i, true);
                }
            }

            // Select text file as default export type.
            List_ExportAs.SelectedIndex = 0;
       
            ValidateExportSettings();
        }

        /// <summary>
        /// Shows a new form instance or focuses the active instance.
        /// </summary>
        /// <param name="document"></param>
        public static void ShowExportForm(Document document)
        {
            // If there is no form active.
            if (activeExportForm == null)
            {
                activeExportForm = new Form_Export(document);
                activeExportForm.FormClosed += delegate 
                { 
                    activeExportForm = null;
                    Logs.LogUserMessage("Cancelling export process.");
                };

                activeExportForm.ShowDialog();

                return;
            }

            // Bring existing form to front.
            activeExportForm.Focus();
        }

        /// <summary>
        /// Validates all relevant export settings and enables/disables export button.
        /// </summary>
        private void ValidateExportSettings()
        {
            bool documentExists = document != null;

            if (!documentExists)
                Logs.LogErrorMessage("Export: Document is null.");
            else
                Logs.LogUserMessage("Beginning export process.");
                          
            // Disable most components if document is null.
            Text_DocumentName.Enabled = documentExists;
            Text_ExportLocation.Enabled = documentExists;
            Button_SelectExportDirectory.Enabled = documentExists;
            Check_CreateDirectory.Enabled = documentExists;
            Check_OpenAfterExport.Enabled = documentExists;
            Check_Overwrite.Enabled = documentExists;
            List_ExportAs.Enabled = documentExists;

            // Check other export settings.
            bool validOutputDirectory = ValidateOutputDirectory();
            bool validDocumentName = ValidateDocumentName();

            // Check export settings.
            bool validExportSettings = documentExists
                && validOutputDirectory
                && validDocumentName;

            // Enable or disable export button based on settings.
            Button_Export.Enabled = validExportSettings;
        }

        /// <summary>
        /// Validates the existence of the output directory.
        /// </summary>
        private bool ValidateOutputDirectory()
        {
            bool directoryExists = Directory.Exists(Text_ExportLocation.Text);

            Text_ExportLocation.BackColor = directoryExists ? Color.White : Color.LightCoral;

            return directoryExists;
        }

        /// <summary>
        /// Returns true if the document name is filesystem-safe.
        /// </summary>
        private bool ValidateDocumentName()
        {
            bool validFileName = !string.IsNullOrEmpty(Text_DocumentName.Text)
                && !string.IsNullOrWhiteSpace(Text_DocumentName.Text)
                && Text_DocumentName.Text.IndexOfAny(Path.GetInvalidFileNameChars()) < 0;

            Text_DocumentName.BackColor = validFileName ? Color.White : Color.LightCoral;

            return validFileName;
        }

        /// <summary>
        /// Gets the indexes of pages selected for export.
        /// </summary>
        private List<int> GetSelectedPages()
        {
            List<int> selectedPages = new List<int>();

            for(int i = 0; i < CheckList_ExportPages.Items.Count; i++)
            {
                if(CheckList_ExportPages.GetItemChecked(i) == true)
                    selectedPages.Add(i);
            }

            return selectedPages;
        }

        /// <summary>
        /// Cancels export and closes form.
        /// </summary>
        private void Button_CancelExport_Click(object sender, EventArgs e)
        => Close();
        
        /// <summary>
        /// Exports selected pages to output directory.
        /// </summary>
        private void Button_Export_Click(object sender, EventArgs e)
        {
            Logs.LogUserMessage("Exporting document.");

            if (document != null)
            {
                TextExport.ExportDocument
                (
                    document,
                    Text_DocumentName.Text,
                    GetSelectedPages(),
                    Text_ExportLocation.Text,
                    Check_CreateDirectory.Checked,
                    Check_OpenAfterExport.Checked,
                    Check_Overwrite.Checked
                );
            } 
        }

        /// <summary>
        /// Validates export settings every time the document name is updated.
        /// </summary>
        private void Text_DocumentName_TextChanged(object sender, EventArgs e)
        => ValidateExportSettings();
        

        /// <summary>
        /// Opens a directory selection dialog.
        /// </summary>
        private void Button_SelectExportDirectory_Click(object sender, EventArgs e)
        => Text_ExportLocation.Text = FileManager.SelectDirectory(Text_ExportLocation.Text);


        /// <summary>
        /// Validates export settings whenever the export folder is changed.
        /// </summary>
        private void Text_ExportLocation_TextChanged(object sender, EventArgs e)
        => ValidateExportSettings();
    }
}
