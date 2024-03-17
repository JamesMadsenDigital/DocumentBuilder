using DocumentBuilder.Forms;
using System;
using System.Collections.Generic;

namespace DocumentBuilder.Debug
{
    /// <summary>
    /// Handles debugging and user logs.
    /// </summary>
    internal static class Logs
    {
        // Log debug messages?
        public static bool showDebugMessages = true;

        // List of messages shown in log.
        private static List<string> logMessages = new List<string>();

        /// <summary>
        /// Adds a new user message to the logs.
        /// </summary>
        public static void LogUserMessage(string message)
        {
            logMessages.Add($"[User] {message} [{DateTime.Now.ToString("hh:mm:ss.fff")}]");

            Form_LogViewer.RefreshLogs();
        }

        /// <summary>
        /// Adds a new debug message to the logs, if debug messages are enabled.
        /// </summary>
        public static void LogDebugMessage(string message)
        {
            if(showDebugMessages)
                logMessages.Add($"[Debug] {message} [{DateTime.Now.ToString("hh:mm:ss:fff")}]");

            Form_LogViewer.RefreshLogs();
        }

        /// <summary>
        /// Adds a new error message to the log.
        /// </summary>
        public static void LogErrorMessage(string message)
        {
            logMessages.Add($"[Error] {message} [{DateTime.Now.ToString("hh:mm:ss:fff")}]");

            Form_LogViewer.RefreshLogs();
        }

        /// <summary>
        /// Returns the current list of log messages.
        /// </summary>
        public static List<string> GetLogMessages()
        {
            return logMessages;
        }

        /// <summary>
        /// Clears list of logs.
        /// </summary>
        public static void ClearLogs()
        {
            logMessages.Clear();

            Form_LogViewer.RefreshLogs();
        }
    }
}
