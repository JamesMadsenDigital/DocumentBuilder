using System;
using System.Drawing;
using System.Windows.Forms;
using DocumentBuilder.FileManagement;
using DocumentBuilder.Components;
using DocumentBuilder.Parsing;
using DocumentBuilder.Rendering;
using DocumentBuilder.Editing;

namespace DocumentBuilder.Forms
{
    /// <summary>
    /// The main form of Document Builder.
    /// </summary>
    public partial class Form_Main : Form
    {
        // Document object stored on form.
        private Document currentDocument = null;

        // Path to document being edited.
        private string openFilePath = "";

        /// <summary>
        /// Form constructor.
        /// </summary>
        public Form_Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Updates syntax highlighting whenever the editor's text is changed.
        /// </summary>
        private void Editor_TextChanged(object sender, EventArgs e)
        {
            SuspendLayout();

            int currentFirstChar = RichText_Editor.GetFirstCharIndexOfCurrentLine();

            int currentLine = RichText_Editor.GetLineFromCharIndex(currentFirstChar);

            SyntaxHighlighting.Update(RichText_Editor, currentLine);

            ResumeLayout();

            // Update document output.
            currentDocument = DocumentParser.ParseDocument(RichText_Editor.Lines);

            Text_Viewer.Lines = ViewRenderer.RenderViewerOutput(currentDocument.GetPage((int)Number_Page.Value - 1));
        }

        /// <summary>
        /// When the page number in the viewer is changed.
        /// </summary>
        private void Number_Page_ValueChanged(object sender, EventArgs e)
        => Text_Viewer.Lines = ViewRenderer.RenderViewerOutput(currentDocument.GetPage((int)Number_Page.Value - 1));
        
        /// <summary>
        /// Opens a new DML or Text File.
        /// </summary>
        private void MenuItem_Open_Click(object sender, EventArgs e)
        {
            string[] openedFileLinens = FileManager.TryOpenFile(ref openFilePath);

            if (openedFileLinens.Length > 0)
                RichText_Editor.Lines = openedFileLinens;

            // Update document output.
            currentDocument = DocumentParser.ParseDocument(RichText_Editor.Lines);

            Text_Viewer.Lines = ViewRenderer.RenderViewerOutput(currentDocument.GetPage((int)Number_Page.Value - 1));

            SyntaxHighlighting.UpdateAll(RichText_Editor, Progress_Import);
        }

        /// <summary>
        /// Updates the font size of the viewer. Changing editor breaks syntax highlighting.
        /// </summary>
        private void Number_FontSize_ValueChanged(object sender, EventArgs e)
        {
            int fontSize = (int)Number_FontSize.Value;

            Text_Viewer.Font = new Font(Text_Viewer.Font.FontFamily, fontSize);
        }

        /// <summary>
        /// Called when 'about' menu item is clicked.
        /// </summary>
        private void MenuItem_About_Click(object sender, EventArgs e)
        => Form_About.ShowAboutForm();

        /// <summary>
        /// Called on form load.
        /// </summary>
        private void Form_Main_Load(object sender, EventArgs e)
        => ComponentManager.UpdateSyntaxHighlighting();

        /// <summary>
        /// Called when 'view logs' menu item is clicked.
        /// </summary>
        private void ListItem_ViewLogs_Click(object sender, EventArgs e)
        => Form_LogViewer.ShowLogViewerForm();

        /// <summary>
        /// Shows the documentation form when menu item is clicked.
        /// </summary>
        private void ListItem_ShowDocumentation_Click(object sender, EventArgs e)
        => Form_Documentation.ShowLogViewerForm();
   
        /// <summary>
        /// Saves the current file, or prompts the user to save it as a new file if 
        /// it doesn't exist.
        /// </summary>
        private void MenuItem_Save_Click(object sender, EventArgs e)
        => FileManager.TrySaveFile(ref openFilePath, RichText_Editor.Lines);

        /// <summary>
        /// Saves a file as new.
        /// </summary>
        private void MenuItem_SaveAs_Click(object sender, EventArgs e)
        => FileManager.SaveFileAs(ref openFilePath, RichText_Editor.Lines);

        /// <summary>
        /// Opens the export dialog.
        /// </summary>
        private void Button_Export_Click(object sender, EventArgs e)
        => Form_Export.ShowExportForm(currentDocument);
    }
}
