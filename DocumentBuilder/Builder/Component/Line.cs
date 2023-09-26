using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentBuilder.Builder
{
    /// <summary>
    /// Represents a line from the document that contains components and/or text.
    /// </summary>
    internal class Line
    {
        // Components attached to line.
        public List<Component> components;

        // Text that is contained on the line.
        public string text;
    }
}
