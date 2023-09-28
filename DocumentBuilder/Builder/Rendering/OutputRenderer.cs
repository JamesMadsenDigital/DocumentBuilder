using DocumentBuilder.Debug;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DocumentBuilder.Builder
{
    /// <summary>
    /// Renders a document object to an ascii string array.
    /// </summary>
    internal static class OutputRenderer
    {
        public static string[] RenderDocument(Page page)
        {
            if (page == null)
                return new string[1] { $"No Page (Are you missing an [EndPage]?)" };

            foreach(Container container in page.containers)
                ComponentRenderer.DrawContainer(page, container);
 
            return GetStringFromCharArray(page);
        }


        /// <summary>
        /// Converts 2D character array to a 1D string array.
        /// </summary>
        private static string[] GetStringFromCharArray(Page page)
        {
            // Get height of char array.
            string[] rawLines = new string[page.height];

            for(int y = 0; y < page.height; y++)
                for(int x = 0; x < page.width; x++)
                    rawLines[y] += page.pageCharArray[x, y];

            return rawLines;
        }

        /// <summary>
        /// Gets a formatted line with asteriks and the line's number.
        /// </summary>
        public static string[] GetFormattedOutput(Page page, string[] rawInput)
        {
            if(page == null)
                return new string[1] { $"No Page (Are you missing an [EndPage]?)" };

            string[] output = new string[rawInput.Length + 2];

            for(int i = 0; i < output.Length; i++)
            {
                if (i == 0 || i == output.Length - 1)
                    output[i] = DrawSpan(page);
                else if (i < rawInput.Length)
                    output[i] = $"{(i - 1).ToString("000")} *{rawInput[i]}*";
            }

            return output;
        }

        /// <summary>
        /// Draws a spanline of asteriks that indicates the top or bottom of a page.
        /// </summary>
        private static string DrawSpan(Page page)
        {
            string span = "    ";

            for(int i = 0; i < page.width; i++)
            {
                span += '*';
            }

            return span + "**";
        }
    }
}
