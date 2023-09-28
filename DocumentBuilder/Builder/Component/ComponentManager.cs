﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DocumentBuilder.Forms.MainForm;
using DocumentBuilder.Debug;

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

            // Containers.
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
                new Dictionary<string, object>
                {

                }
            ),

            new ComponentTemplate
            (
                "HSpacer",
                Color.Plum,
                new Dictionary<string, object>
                {
                    { "SplitIndex", 0 }
                }
            ),

            // VSpacer and HSpacer.
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
            Debug.Logs.LogDebugMessage("Updating syntax highlighting.");

            foreach(var component in pageComponents)
                KeyWords.AddByColor(component.name, component.syntaxColor);
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
