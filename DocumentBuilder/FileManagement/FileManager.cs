using System;
using System.IO;
using System.Windows.Forms;
using DocumentBuilder.Debug;

namespace DocumentBuilder.FileManagement
{
    /// <summary>
    /// Manages application files and paths.
    /// </summary>
    internal static class FileManager
    {
        /// <summary>
        /// Creates and writes a file.
        /// </summary>
        public static void CreateFile(string path, string[] lines)
        {
            try
            {
                File.WriteAllLines(path, lines);
            }
            catch(Exception e)
            {
                Logs.LogErrorMessage($"Error saving file {path}: " + e.Message);

                string caption = "Error";
                string message = $"Error saving file {path}: " + e.Message;

                MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Tries to save a file at the path specified. Can be .dml or .txt.
        /// </summary>
        public static string TrySaveFile(string path, string[] lines)
        {
            // Prompt user to save file if it doesn't currently exist.
            if (!File.Exists(path))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.RestoreDirectory = true;

                saveFileDialog.Filter = "Document markup file (.dml)|*.dml|Text file(.txt)|*.txt";

                saveFileDialog.Title = "Save Document";

                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Logs.LogUserMessage($"Saving file to {Path.GetFullPath(saveFileDialog.FileName)}");

                        File.WriteAllLines(Path.GetFullPath(saveFileDialog.FileName), lines);
                    }
                    catch(Exception e)
                    {
                        Logs.LogErrorMessage("Error saving file: " + e.Message);

                        string caption = "Error";
                        string message = "Error saving file: " + e.Message;

                        MessageBox.Show(message, caption, MessageBoxButtons.OK);

                        return path;
                    }

                    return Path.GetFullPath(saveFileDialog.FileName);
                }

                return path;
            }

            // If the file already exists, write over it.
            try
            {
                Logs.LogUserMessage($"Saving file to {path}");

                File.WriteAllLines(path, lines);

                return path;
            }
            catch(Exception e)
            {
                Logs.LogErrorMessage("Error saving file: " + e.Message);

                string caption = "Error";
                string message = "Error saving file: " + e.Message;

                MessageBox.Show(message, caption, MessageBoxButtons.OK);

                return path;
            }
        }      

        /// <summary>
        /// Saves a file that may or may not already exist, with a new name/path.
        /// </summary>
        public static string SaveFileAs(string currentPath, string[] lines)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.RestoreDirectory = true;

            saveFileDialog.Filter = "Document markup file (.dml)|*.dml|Text file(.txt)|*.txt";

            saveFileDialog.Title = "Save Document As";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Logs.LogUserMessage($"Saving file to {Path.GetFullPath(saveFileDialog.FileName)}");

                    File.WriteAllLines(Path.GetFullPath(saveFileDialog.FileName), lines);

                    return Path.GetFullPath(saveFileDialog.FileName);
                }
                catch (Exception e)
                {
                    Logs.LogErrorMessage("Error saving file: " + e.Message);
                    string caption = "Error";
                    string message = "Error saving file: " + e.Message;

                    MessageBox.Show(message, caption, MessageBoxButtons.OK);

                    return currentPath;
                }

                return Path.GetFullPath(saveFileDialog.FileName);
            }

            return currentPath;
        }

        /// <summary>
        /// Tries to open a file, and returns an empty string array if it can't
        /// </summary>
        public static string TryOpenFile(RichTextBox textBox, string currentPath)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.RestoreDirectory = true;

            openFileDialog.Filter = "Document markup file (.dml)|*.dml|Text file(.txt)|*.txt";

            openFileDialog.Title = "Open Document";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    textBox.Lines = File.ReadAllLines(openFileDialog.FileName);

                    currentPath = Path.GetFullPath(openFileDialog.FileName);

                    Logs.LogUserMessage($"Opened {currentPath}");

                    return currentPath;
                }
                catch(Exception e)
                {
                    Logs.LogErrorMessage("Error opening file: " + e.Message);
                    string caption = "Error";
                    string message = "Error saving file: " + e.Message;

                    MessageBox.Show(message, caption, MessageBoxButtons.OK);

                    return currentPath;
                }
            }

            return currentPath;
        }


        /// <summary>
        /// Opens a directory selection dialog, and returns the selected path.
        /// </summary>
        public static string SelectDirectory(string currentDirectory)
        {
             FolderBrowserDialog selectFolderDialog = new FolderBrowserDialog();

            if(selectFolderDialog.ShowDialog() == DialogResult.OK)
            {
                return selectFolderDialog.SelectedPath;
            }

            return currentDirectory;
        }
    }
}
