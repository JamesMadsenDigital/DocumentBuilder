using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DocumentBuilder.Forms.MainForm;
using DocumentBuilder.Logs;

namespace DocumentBuilder.Builder
{
    internal static class ComponentManager
    {
        // List of available components.
        private static List<ComponentTemplate> pageComponents = new List<ComponentTemplate>
        {
            // Pages.
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
                new Dictionary<string, object>{}
            ),

            // ColumnGroups.
            new ComponentTemplate
            (
                "ColumnGroup",
                Color.CornflowerBlue,
                new Dictionary<string, object>
                {
                    { "Width", 50 },
                    { "Height", 30 }
                }
            ),
            new ComponentTemplate
            (
                "EndColumnGroup",
                Color.CornflowerBlue,
                new Dictionary<string, object>{}
            ),

            // Columns.
            new ComponentTemplate
            (
                "Column",
                Color.BlueViolet,
                new Dictionary<string, object>
                {
                    { "Width", 20 },
                    { "Height", 30 },
                    { "Alignment", "Left" }
                }
            ),
            new ComponentTemplate
            (
                "EndColumn",
                Color.BlueViolet,
                new Dictionary<string, object>{}
            ),

            // VSpacer and HSpacer.
            new ComponentTemplate
            (
                "VSpacer",
                Color.Violet,
                new Dictionary<string, object>
                {
                    { "Height", 1 }
                }
            ),
            new ComponentTemplate
            (
                "HSpacer",
                Color.Violet,
                new Dictionary<string, object>{}
            ),

            // VSpacer and HSpacer.
            new ComponentTemplate
            (
                "HSpan",
                Color.Plum,
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
            LogManager.LogDebugMessage("Updating syntax highlighting.");

            foreach(var component in pageComponents)
                KeyWords.AddByColor(component.name, component.syntaxColor);
        }

        /// <summary>
        /// Returns a default component and its properties.
        /// </summary>
        public static Component DefaultComponent(string name)
        {
            ComponentTemplate template = pageComponents.Find(x => x.Equals(name));

            if (template == null)
                return null;

            return new Component(template);
        }
    }
}
