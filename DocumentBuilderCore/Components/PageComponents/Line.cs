using DocumentBuilder.Debug;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DocumentBuilderCore.Components
{
    /// <summary>
    /// Represents a line from the document that contains components and/or text.
    /// </summary>
    internal class Line
    {
        // Text that is contained on the line.
        public string text = "";

        // Components attached to line.
        public Component lineComponent;

        /// <summary>
        /// Gets a component from the list.
        /// </summary>
        public Component GetComponent(string name)
        {
            if (lineComponent == null)
                return null;

            if(lineComponent.name.Equals(name))
                return lineComponent;
            else 
                return null;
        }

        /// <summary>
        /// Ad
        /// </summary>
        /// <param name="component"></param>
        public void AddComponent(Component component)
        {
            lineComponent = component;
        }
    }
}
