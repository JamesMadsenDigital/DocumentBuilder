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
        }

        private void ProgressBar_DocumentBuild_Click(object sender, EventArgs e)
        {

        }
    }
}
