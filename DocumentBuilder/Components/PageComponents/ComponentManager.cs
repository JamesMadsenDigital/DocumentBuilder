using System.Collections.Generic;
using System.Drawing;
using DocumentBuilder.Editing;

namespace DocumentBuilder.Components
{
    /// <summary>
    /// Manages a list of component templates.
    /// </summary>
    internal static class ComponentManager
    {
        // List of available components.
        private static List<ComponentTemplate> pageComponents = new List<ComponentTemplate>
        {
            // Page / EndPage.
            new ComponentTemplate
            (
                "Page", 
                Color.Blue, 
                new Dictionary<string, object>
                {
                    { "Width", 50 },
                    { "Height", 80 }
                }
            ),
            new ComponentTemplate
            (
                "EndPage",
                Color.Blue,
                new Dictionary<string, object>{ }
            ),

            // Container / EndContainer.
            new ComponentTemplate
            (
                "Container",
                Color.CornflowerBlue,
                new Dictionary<string, object>
                {
                    { "X", -1 },
                    { "Y", 0 },
                    { "Width", -1 },
                    { "Alignment", "Left" },
                }
            ),
            new ComponentTemplate
            (
                "EndContainer",
                Color.CornflowerBlue,
                new Dictionary<string, object>{ }
            ),

            // HSpacer.
            new ComponentTemplate
            (
                "HSpacer",
                Color.Plum,
                new Dictionary<string, object>{ }
            ),

            // HSpan.
            new ComponentTemplate
            (
                "HSpan",
                Color.DarkTurquoise,
                new Dictionary<string, object>
                {
                    { "SpanChar", 1 }
                }
            ),
        };

        /// <summary>
        /// Builds syntax highlighting for components.
        /// </summary>
        public static void UpdateSyntaxHighlighting()
        {
            foreach(var componentTemplate in pageComponents)
                KeywordManager.AddByColor(componentTemplate.name, componentTemplate.syntaxColor);
        }

        /// <summary>
        /// Returns a component template.
        /// </summary>
        public static ComponentTemplate GetComponentTemplate(string name)
        {
            ComponentTemplate template = pageComponents.Find(x => x.name == name);

            return template;
        }
    }
}
