using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DocumentBuilder.Builder
{
    /// <summary>
    /// Template for a component.
    /// </summary>
    internal class ComponentTemplate
    {
        // Name of the component
        public string name { get; private set; }

        // Color component is drawn with in editor.
        public Color syntaxColor { get; private set; }

        // Default properties of the component
        public Dictionary<string, object> properties { get; private set; }

        /// <summary>
        /// Constructor for a component template.
        /// </summary>
        public ComponentTemplate(string name, Color syntaxColor, Dictionary<string, object> defaultProperties)
        {
            this.name = name;
            this.syntaxColor = syntaxColor;
            properties = defaultProperties;
        }
    }
}
