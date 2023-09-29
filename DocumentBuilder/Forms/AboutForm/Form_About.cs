using DocumentBuilder.Debug;
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
    /// Form showing details about the Document Builder project.
    /// </summary>
    public partial class Form_About : Form
    {
        // Force single form instance.
        private static Form_About activeAboutForm = null;

        public static void ShowAboutForm()
        {
            Debug.Logs.LogDebugMessage("Showing About form.");
            // If there is no form active.
            if(activeAboutForm == null)
            {
                activeAboutForm = new Form_About();
                activeAboutForm.FormClosed += delegate { activeAboutForm = null; };

                activeAboutForm.Show();

                return;
            }

            // Bring existing form to front.
            activeAboutForm.Focus();
        }

        /// <summary>
        /// Form constructor.
        /// </summary>
        public Form_About()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens portfolio page in web browser.
        /// </summary>
        private void Link_Portfolio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.jamesmadsendigital.com/documentbuilder");
        }

        /// <summary>
        /// Opens GitHub repository in web browser.
        /// </summary>
        private void Link_GitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/JamesMadsenDigital/DocumentBuilder.git");
        }
    }
}
