using DocumentBuilder.Builder;
using DocumentBuilder.Forms;
using DocumentBuilder.Forms.MainForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentBuilder.Forms
{
    /// <summary>
    /// The main form of Document Builder
    /// </summary>
    public partial class Form_Main : Form
    {
        // Document object stored on form.
        private Document currentDocument = null;

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
        /// Shows the log viewer form when the progress bar is clicked.
        /// </summary>
        private void ProgressBar_DocumentBuild_Click(object sender, EventArgs e)
        {
            Form_LogViewer.ShowLogViewerForm();
        }

        /// <summary>
        /// When the page number in the viewer is changed.
        /// </summary>
        private void Number_Page_ValueChanged(object sender, EventArgs e)
        {
            Text_Viewer.Lines = OutputRenderer.RenderDocument(currentDocument.GetPage((int)Number_Page.Value));
        }


        private void Button_PrintComponents_Click(object sender, EventArgs e)
        {
            Form_LogViewer.ShowLogViewerForm();

            DocumentDebug.PrintComponents(currentDocument);
        }
    }
}
