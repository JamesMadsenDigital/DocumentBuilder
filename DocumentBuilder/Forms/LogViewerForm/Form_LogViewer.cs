﻿using System;
using System.Windows.Forms;

namespace DocumentBuilder.Forms
{
    /// <summary>
    /// Form for viewing log messages.
    /// </summary>
    public partial class Form_LogViewer : Form
    {
        // Force single form instance.
        private static Form_LogViewer activeLogViewerForm = null;

        public static void ShowLogViewerForm()
        {
            Debug.Logs.LogDebugMessage("Showing LogViewer form.");
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
        => LoadLogs();

        /// <summary>
        /// Clears logs.
        /// </summary>
        private void Button_ClearLogs_Click(object sender, EventArgs e)
        => Debug.Logs.ClearLogs();

        /// <summary>
        /// Refre
        /// </summary>
        protected void LoadLogs()
        {
            // Clear list.
            List_Logs.Items.Clear();

            // Add each log to the list.
            foreach(string logMessage in Debug.Logs.GetLogMessages())
                List_Logs.Items.Add(logMessage);
        }
    }
}
