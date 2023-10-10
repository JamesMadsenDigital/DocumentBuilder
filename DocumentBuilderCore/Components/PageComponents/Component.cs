using System.Collections.Generic;

namespace DocumentBuilderCore.Components
{
    /// <summary>
    /// Class that desribes a component that is drawn to the page.
    /// </summary>
    internal class Component
    {
        // Parent component.
        public Component parent = null;

        // The raw text of the component declaration.
        public string rawText;

        // The horizontal index of the raw component declaration.
        public int index = 0;

        // Properties of the component.
        private List<Property> properties = new List<Property>();

        // Name of the component.
        public string name = "Component";

        /// <summary>
        /// Gets a property that is assumed to be an int and returns
        /// a default value if it's not an integer.
        /// </summary>
        public int GetIntProperty(string propertyName, int defaultValue)
        {
            Property matchingProperty = properties.Find(x => x.name == propertyName);

            if (matchingProperty == null)
                return defaultValue;

            if (matchingProperty.value is int)
                return (int)matchingProperty.value;
 
            return defaultValue;
        }

        /// <summary>
        /// Gets a property that is assumed to be a string and returns 
        /// a default value if it's not a string.
        /// </summary>
        public string GetStringProperty(string propertyName, string defaultValue)
        {
            Property matchingProperty = properties.Find(x => x.name == propertyName);

            if (matchingProperty == null)
                return defaultValue;

            if (matchingProperty.value is string)
                return (string)matchingProperty.value;

            return defaultValue;
        }

        /// <summary>
        /// Returns the hash code of the properties list.
        /// </summary>
        /// <returns></returns>
        public string GetPropertiesHash()
        {
            return properties.GetHashCode().ToString();
        }

        /// <summary>
        /// Sets a property key if it exists, and creates a new one if it doesn't.
        /// </summary>
        public void SetProperty(string propertyName, object value)
        {
            Property matchingProperty = properties.Find(x => x.name == propertyName);

            if(matchingProperty == null)
            {
                properties.Add(new Property(propertyName, value));
                return;
            }

            matchingProperty.value = value;
        }
    }

    /// <summary>
    /// Contains a name and value pair.
    /// </summary>
    internal class Property
    {
        public string name;

        public object value;

        /// <summary>
        /// Constructor for a component property.
        /// </summary>
        public Property(string name, object value) 
        {
            this.name = name;
            this.value = value;
        }
    }
}
