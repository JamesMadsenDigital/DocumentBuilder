using System.Windows.Forms;

namespace DocumentBuilder.Forms
{
    /// <summary>
    /// Form containing documentation and guidelines for Document Builder.
    /// </summary>
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
