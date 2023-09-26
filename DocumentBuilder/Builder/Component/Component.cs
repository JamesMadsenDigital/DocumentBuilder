using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DocumentBuilder.Builder
{
    /// <summary>
    /// Class that desribes a component that is drawn to the page.
    /// </summary>
    internal class Component
    {
        // Parent component.
        public Component parent = null;

        // Properties of the component.
        public Dictionary<string,object> properties = new Dictionary<string,object>();

        // Name of the component.
        public string name = "Component";

        /// <summary>
        /// Template constructor for components.
        /// </summary>
        public Component(ComponentTemplate template)
        {
            name = template.name;
            this.properties = template.properties;
        }

        /// <summary>
        /// Gets a property by name and returns a default value if it is not found.
        /// </summary>
        public object GetProperty(string name, object defaultValue)
        {
            if(properties.ContainsKey(name))
                return properties[name];

            return defaultValue;
        }
    }
}
