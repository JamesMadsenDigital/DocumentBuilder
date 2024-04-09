namespace DocumentBuilder.Components
{
    /// <summary>
    /// Describes a line from the document that contains components and/or text.
    /// </summary>
    internal class Line
    {
        // Text that is contained on the line.
        public string outputText = "";

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
        /// Sets component that is attached to line.
        /// </summary>
        public void SetComponent(Component component)
        => lineComponent = component;
    }
}
