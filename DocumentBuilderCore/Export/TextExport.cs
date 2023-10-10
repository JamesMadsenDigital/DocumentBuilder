using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using DocumentBuilder.Components;
using DocumentBuilder.Debug;
using DocumentBuilder.FileManagement;
using DocumentBuilder.Output;

namespace DocumentBuilderCore.Export
{
    internal static class TextExport
    {
        /// <summary>
        /// Exports the selected pages of a document to the specified output folder.
        /// </summary>
        public static void ExportDocument
        (
            Document document,
            string name,
            List<int> pages, 
            string path, 
            bool createDirectory, 
            bool showOutputFolder,
            bool overwriteExisting
        )
        {
            string outputPath = path;

            // Create output directory if specified.
            try
            {
                if (createDirectory)
                {
                    outputPath = path + $"\\{name}";

                    Directory.CreateDirectory(outputPath);
                }
            }
            catch(Exception e)
            {
                Logs.LogErrorMessage("Error creating output directory: " + e.Message);

                string caption = "Error";
                string message = "Error creating output directory: " + e.Message;

                MessageBox.Show(message, caption, MessageBoxButtons.OK);

                return;
            }

            // Create each page
            foreach(int pageIndex in pages)
            {
                string[] pageLines = DocumentOutput.GetPage(document.pages[pageIndex]); 

                // Example file name: Document_Page0.txt
                string fileName = $"{name}_Page{pageIndex}.txt";

                string fullPath = Path.Combine(outputPath, fileName);

                // Create the file in the output directory.
                if (overwriteExisting || (!overwriteExisting && !File.Exists(fullPath)))
                    FileManager.CreateFile(fullPath, pageLines);
                else
                    Logs.LogUserMessage($"File {fileName} already exists in output directory, skipping export.");
            }

            // Show the output folder, if desired.
            if (showOutputFolder)
            {
                if (Directory.Exists(outputPath))
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        Arguments = outputPath,
                        FileName = "explorer.exe"
                    };

                    Process.Start(startInfo);
                }
            }
        }
    }
}
