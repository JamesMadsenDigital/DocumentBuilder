using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentBuilder.Forms.DocumentationForm
{
    public partial class Form_Documentation : Form
    {
        // Force single form instance.
        private static Form_Documentation activeDocumentationForm = null;

        public static void ShowLogViewerForm()
        {
            Debug.Logs.LogDebugMessage("Showing LogViewer form.");
            // If there is no form active.
            if (activeDocumentationForm == null)
            {
                activeDocumentationForm = new Form_Documentation();
                activeDocumentationForm.FormClosed += delegate { activeDocumentationForm = null; };

                activeDocumentationForm.Show();

                return;
            }

            // Bring existing form to front.
            activeDocumentationForm.Focus();
        }

        /// <summary>
        /// Form constructor.
        /// </summary>
        public Form_Documentation()
        {
            InitializeComponent();
        }
    }
}
