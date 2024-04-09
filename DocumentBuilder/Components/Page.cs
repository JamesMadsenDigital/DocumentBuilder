using System.Collections.Generic;

namespace DocumentBuilder.Components
{
    /// <summary>
    /// Describes one page of a document with lines and containers.
    /// </summary>
    internal class Page
    {
        // Width and height of the page.
        public int width = 80;
        public int height = 50;

        // The unsorted lines that are on the page.
        public List<Line> lines = new List<Line>();

        // Containers that are drawn to the page output.
        public List<Container> containers = new List<Container>();

        // Array of characters that are rendered onto the screen.
        public char[,] pageCharArray;

        /// <summary>
        /// Constructor for a page.
        /// </summary>
        public Page(int width, int height)
        {
            // Minimum height and width are 5.
            if (width < 10) width = 10;
            if (height < 10) height = 10;

            this.width = width;
            this.height = height;

            GenerateCharArray();
        }

        /// <summary>
        /// Generates the page's character array and populates it with spaces.
        /// </summary>
        private void GenerateCharArray()
        {
            pageCharArray = new char[width, height];

            for(int x = 0; x < width; x++)
                for(int y = 0; y < height; y++)
                    pageCharArray[x, y] = ' ';
        }
    }
}
