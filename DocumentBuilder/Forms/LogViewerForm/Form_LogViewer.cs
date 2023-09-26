using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentBuilder.Logs;

namespace DocumentBuilder.Forms
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Form_LogViewer : Form
    {
        // Force single form instance.
        private static Form_LogViewer activeLogViewerForm = null;

        public static void ShowLogViewerForm()
        {
            LogManager.LogDebugMessage("Showing LogViewer form.");
            // If there is no form active.
            if (activeLogViewerForm == null)
            {
                activeLogViewerForm = new Form_LogViewer();
                activeLogViewerForm.FormClosed += delegate { activeLogViewerForm = null; };

                activeLogViewerForm.Show();

                return;
            }

            // Bring existing form to front.
            activeLogViewerForm.Focus();
        }

        /// <summary>
        /// Refreshes the list of logs.
        /// </summary>
        public static void RefreshLogs()
        {
            if (activeLogViewerForm != null)
            {
                activeLogViewerForm.LoadLogs();
            }
        }

        /// <summary>
        /// Form constructor.
        /// </summary>
        public Form_LogViewer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called on form load.
        /// </summary>
        private void Form_LogViewer_Load(object sender, EventArgs e)
        {
            LoadLogs();
        }

        /// <summary>
        /// Clears logs.
        /// </summary>
        private void Button_ClearLogs_Click(object sender, EventArgs e)
        {
            LogManager.ClearLogs();
        }

        /// <summary>
        /// Refre
        /// </summary>
        protected void LoadLogs()
        {
            // Clear list.
            List_Logs.Items.Clear();

            // Add each log to the list.
            foreach(string logMessage in LogManager.GetLogMessages())
                List_Logs.Items.Add(logMessage);
        }
    }
}
