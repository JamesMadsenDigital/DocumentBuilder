using System.Collections.Generic;
using System.Drawing;

namespace DocumentBuilder.Components
{
    /// <summary>
    /// Template for a page component.
    /// </summary>
    internal class ComponentTemplate
    {
        // Name of the component.
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
