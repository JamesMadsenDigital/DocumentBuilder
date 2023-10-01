using DocumentBuilder.Components;
using DocumentBuilder.Output;

namespace DocumentBuilder.Rendering
{
    internal static class ViewRenderer
    {
        /// <summary>
        /// Gets a formatted line with asteriks and the line's number.
        /// </summary>
        public static string[] RenderViewerOutput(Page page)
        {
            string[] rawPageLines = DocumentOutput.GetPage(page);

            if (page == null)
                return new string[1] { $"No Page (Are you missing an [EndPage]?)" };

            string[] output = new string[rawPageLines.Length + 2];

            for (int i = 0; i < output.Length; i++)
            {
                if (i == 0 || i == output.Length - 1)
                    output[i] = DrawSpan(page);
                else if (i < rawPageLines.Length)
                    output[i] = $"{(i - 1).ToString("000")} *{rawPageLines[i]}*";
            }

            return output;
        }

        /// <summary>
        /// Draws a spanline of asteriks that indicates the top or bottom of a page.
        /// </summary>
        private static string DrawSpan(Page page)
        {
            string span = "    ";

            for (int i = 0; i < page.width; i++)
                span += '*';

            return span + "**";
        }
    }
}
