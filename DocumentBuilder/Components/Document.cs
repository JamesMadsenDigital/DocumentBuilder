using System.Collections.Generic;

namespace DocumentBuilder.Components
{
    /// <summary>
    /// Describes for parsed document.
    /// </summary>
    internal class Document
    {
        // List of pages in the document.
        public List<Page> pages = new List<Page>();

        /// <summary>
        /// Constructor for a new document instance.
        /// </summary>
        public Document(List<Page> pages)
        {
            this.pages = pages;
        }

        /// <summary>
        /// Gets a document page from an index.
        /// </summary>
        public Page GetPage(int index)
        {
            if (index >= pages.Count || pages.Count == 0)
                return null;

            return pages[index];
        }
    }
}
