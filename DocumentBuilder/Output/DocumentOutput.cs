using DocumentBuilder.Components;
using DocumentBuilder.Rendering;

namespace DocumentBuilder.Output
{
    /// <summary>
    /// Handles conversion of page objects to string outputs.
    /// </summary>
    internal static class DocumentOutput
    {

        public static string[] GetPage(Page page)
        {
            if (page == null)
                return new string[1] { $"No Page (Are you missing an [EndPage]?)" };

            foreach (Container container in page.containers)
                ComponentRenderer.DrawContainer(page, container);

            return PageToStringArray(page);
        }

        /// <summary>
        /// Renders a page to a string array.
        /// </summary>
        public static string[] PageToStringArray(Page page)
        {
            // Get height of char array.
            string[] rawLines = new string[page.height];

            for (int y = 0; y < page.height; y++)
                for (int x = 0; x < page.width; x++)
                    rawLines[y] += page.pageCharArray[x, y];

            return rawLines;
        }
    }
}
