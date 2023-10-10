using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentBuilder.Components
{
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
        public Container(int horizontalPosition, int verticalPosition, int width, string alignment, List<int> lines)
        {
            this.yPosition = verticalPosition;
            this.xPosition = horizontalPosition;
            this.width = width;
            this.alignment = alignment;
            this.lines = lines;
        }
    }
}

