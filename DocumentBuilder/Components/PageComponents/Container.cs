using System.Collections.Generic;

namespace DocumentBuilder.Components
{
    /// <summary>
    /// Describes a text container that is rendered on a page.
    /// </summary>
    internal class Container
    {
        // Horizontal position (optional).
        public int xPosition;

        // Vertical position on the page (0 = top)
        public int yPosition;

        // Width of the container.
        public int width;

        // Which side of the page the container goes to.
        public string alignment = "Left";

        // List of line indexes that are within the container.
        public List<int> lines;

        // Constructor for a container instance.
        public Container(int xPosition, int yPosition, int width, string alignment, List<int> lines)
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
            this.width = width;
            this.alignment = alignment;
            this.lines = lines;
        }
    }
}

