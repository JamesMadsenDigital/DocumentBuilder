using System.Windows.Forms;

namespace DocumentBuilder.Forms
{
    /// <summary>
    /// Form that documents how to use Document Builder.
    /// </summary>
    public partial class Form_Documentation : Form
    {
        // Singleton form instance.
        private static Form_Documentation activeDocumentationForm = null;

        /// <summary>
        /// Shows new about form if none exists, or current form if one is already open.
        /// </summary>
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
