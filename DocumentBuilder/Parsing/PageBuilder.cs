using System.Collections.Generic;
using DocumentBuilder.Components;

namespace DocumentBuilder.Parsing
{
    internal static class PageBuilder
    {
        /// <summary>
        /// Builds pages from a list of lines.
        /// </summary>
        public static List<Page> BuildPages(List<Line> lines)
        {
            List<Page> pages = new List<Page>();

            for (int i = 0; i < lines.Count; i++)
            {
                Component page = lines[i].GetComponent("Page");

                if (page == null)
                    continue;

                int endIndex = GetEndOfPage(i, lines);

                // If we found a valid end to the page.
                if(endIndex != -1)
                {
                    Page newPage = new Page
                    (
                        page.GetIntProperty("Width", 80),
                        page.GetIntProperty("Height", 50)
                    );

                    newPage.lines = GetLines(i, endIndex, lines);

                    // Add page to document.
                    pages.Add(newPage);

                    // Build all containers on the page.
                    ContainerBuilder.BuildContainers(ref newPage);

                    // Skip to end of page to continue iteration.
                    i = endIndex;
                }
            }

            return pages;
        }

        /// <summary>
        /// Gets the list of lines between startIndex and endIndex.
        /// </summary>
        private static List<Line> GetLines(int startIndex, int endIndex, List<Line> lines)
        {
            List<Line> pageLines = new List<Line>();

            for(int i = startIndex; i < endIndex; i++)
                pageLines.Add(lines[i]);

            return pageLines;
        }

        /// <summary>
        /// Finds the end index of a page that begins at the start index.
        /// </summary>
        private static int GetEndOfPage(int startIndex, List<Line> lines)
        {
            int endIndex = -1;

            // Iterate from the bottom up.
            for(int i = startIndex; i < lines.Count; i++)
            {
                Component endPage = lines[i].GetComponent("EndPage");

                if (endPage == null)
                    continue;

                return i;
            }

            return endIndex;
        }
    }
}
