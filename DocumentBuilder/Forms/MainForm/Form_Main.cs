using DocumentBuilder.Builder;
using DocumentBuilder.Forms.DocumentationForm;
using DocumentBuilder.Forms.MainForm;
using DocumentBuilder.FileManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DocumentBuilder.Forms
{
    /// <summary>
    /// The main form of Document Builder
    /// </summary>
    public partial class Form_Main : Form
    {
        // Document object stored on form.
        private Document currentDocument = null;

        // Path to document being edited.
        private string openFilePath = "";
        public string OpenFilePath
        {
            get { return openFilePath; }

            set 
            {
                openFilePath = value;
                Text_InputFilePath.Text = openFilePath;
            }
        }

        /// <summary>
        /// Form constructor.
        /// </summary>
        public Form_Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called when 'about' menu item is clicked.
        /// </summary>
        private void MenuItem_About_Click(object sender, EventArgs e)
        {
            Form_About.ShowAboutForm();
        }

        /// <summary>
        /// Called on form load.
        /// </summary>
        private void Form_Main_Load(object sender, EventArgs e)
        {
            ComponentManager.UpdateSyntaxHighlighting();
        }

        /// <summary>
        /// Called when 'view logs' menu item is clicked.
        /// </summary>
        private void ListItem_ViewLogs_Click(object sender, EventArgs e)
        {
            Form_LogViewer.ShowLogViewerForm();
        }

        /// <summary>
        /// Updates syntax highlighting whenever the editor's text is changed.
        /// </summary>
        private void Editor_TextChanged(object sender, EventArgs e)
        {
            SyntaxHighlighting.Update(RichText_Editor);

            // Update document output.
            currentDocument = DocumentParser.ParseDocument(RichText_Editor.Lines);

            string[] renderedDocument = OutputRenderer.RenderDocument(currentDocument.GetPage((int)Number_Page.Value));

            Text_Viewer.Lines = OutputRenderer.GetFormattedOutput(currentDocument.GetPage((int)Number_Page.Value), renderedDocument);
        }

        /// <summary>
        /// When the page number in the viewer is changed.
        /// </summary>
        private void Number_Page_ValueChanged(object sender, EventArgs e)
        {
            Text_Viewer.Lines = OutputRenderer.RenderDocument(currentDocument.GetPage((int)Number_Page.Value));
        }

        /// <summary>
        /// Opens a new DML or Text File.
        /// </summary>
        private void MenuItem_Open_Click(object sender, EventArgs e)
        {
            OpenFilePath = FileManager.TryOpenFile(RichText_Editor, OpenFilePath);
        }

        /// <summary>
        /// Shows the documentation form when menu item is clicked.
        /// </summary>
        private void ListItem_ShowDocumentation_Click(object sender, EventArgs e)
        {
            Form_Documentation.ShowLogViewerForm();
        }

        /// <summary>
        /// Saves the current file, or prompts the user to save it as a new file if 
        /// it doesn't exist.
        /// </summary>
        private void MenuItem_Save_Click(object sender, EventArgs e)
        {
            OpenFilePath = FileManager.TrySaveFile(RichText_Editor.Lines, OpenFilePath);
        }

        /// <summary>
        /// Saves a file as new.
        /// </summary>
        private void MenuItem_SaveAs_Click(object sender, EventArgs e)
        {
            OpenFilePath = FileManager.SaveFileAs(OpenFilePath, RichText_Editor.Lines);
        }

        /// <summary>
        /// Updates the font size of the viewer. Changing editor breaks syntax highlighting.
        /// </summary>
        private void Number_FontSize_ValueChanged(object sender, EventArgs e)
        {
            int fontSize = (int)Number_FontSize.Value;

            Text_Viewer.Font = new Font(Text_Viewer.Font.FontFamily, fontSize);
        }
    }
}
