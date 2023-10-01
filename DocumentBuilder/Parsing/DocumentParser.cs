using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using DocumentBuilder.Debug;
using DocumentBuilder.Components;

namespace DocumentBuilder.Parsing
{
    /// <summary>
    /// Handles parsing of document from string array to array of lines and components.
    /// </summary>
    internal static class DocumentParser
    {
        /// <summary>
        /// Parses an array of strings into a document.
        /// </summary>
        public static Document ParseDocument(string[] rawLines)
        {
            // List of lines in document.
            List<Line> lines = new List<Line>();

            for(int i = 0; i < rawLines.Length; i++)
            {
                // Ignore comments.
                if (IsComment(rawLines[i]))
                {
                    Logs.LogDebugMessage("This is a comment, ignoring.");
                    continue;
                }

                Line newLine = CreateLine(rawLines[i]);

                lines.Add(newLine);
            }

            // Build pages.
            List<Page> pages = PageBuilder.BuildPages(lines);

            // Return newly created document.
            return new Document(pages);
        }

        /// <summary>
        /// Creates a line with text and components.
        /// </summary>
        private static Line CreateLine(string rawLine)
        {
            Line newLine = new Line();

            // Extract first component match.
            Regex components = new Regex("\\[(.*?)\\]");

            Match componentMatch = components.Match(rawLine);

            string potentialComponent = componentMatch.Value;

            Regex componentName = new Regex(@"[A-Za-z]*");

            List<string> componentNames = componentName.Matches(potentialComponent)
                .Cast<Match>()
                .Select(m => m.Value)
                .ToList();

            // Remove empty string matches.
            componentNames.RemoveAll(x => x.Length == 0);

            if (componentNames.Count == 0)
                goto NoComponent;

            // Component name will always be the first word in a sequence.
            string component = componentNames[0];

            // Get component template that matches component name.
            ComponentTemplate template = ComponentManager.GetComponentTemplate(component);

            if (template == null)
                goto NoComponent;

            Component newComponent = new Component();

            newComponent.name = template.name;
                
            // Copy values from dictionary.
            foreach(KeyValuePair<string, object> property in template.properties)
            {
                newComponent.SetProperty(property.Key, property.Value);
            }
    
            // Set rawtext and horizontal index of the new component.
            newComponent.rawText = potentialComponent;

            newComponent.index = componentMatch.Index;

            // Get properties of new component (between first/only set of parentheses).
            Regex componentProperties = new Regex(@"\(.*\)");

            Match properties = componentProperties.Match(potentialComponent);

            // Minimum length for the properties field is 5 "(X=4)".
            if (properties.Value.Length < 5)
                goto AddComponent;

            // Remove parentheses from regex result.
            string trimmedProperties = properties.Value.Substring(1, properties.Value.Length - 2);

            // Split properties at commas.
            string[] splitProperties = trimmedProperties.Split(',');

            foreach(string rawProperty in splitProperties)
            {
                // Remove whitespaces and parentheses left over from Regex.
                string property = rawProperty.Trim();

                property = rawProperty.Replace("(", "");
                property = property.Replace(")", "");

                if (!property.Contains('='))
                    continue;

                // First index of an equals sign.
                int splitIndex = property.IndexOf('=');

                // Get property name.
                string propertyName = property.Substring(0, splitIndex);

                // Remove whitespaces from property name.
                propertyName = propertyName.Trim();

                // Get property value.
                string propertyValue = property.Substring(splitIndex + 1, property.Length - splitIndex - 1);

                // If there is no value after the =, or it's just whitespace.
                if (propertyValue.Length == 0 || string.IsNullOrWhiteSpace(propertyValue))
                    continue;

                // Attempt to save property as an integer first.
                int valueAsInt = 0;

                if (int.TryParse(propertyValue, out valueAsInt))
                    newComponent.SetProperty(propertyName, valueAsInt);
                else
                    newComponent.SetProperty(propertyName, propertyValue);
            }

            AddComponent:

            newLine.AddComponent(newComponent);
            

            NoComponent:

            // Remove valid component declarations from the raw text.
            newLine.text = RemoveComponents(rawLine, newLine.lineComponent);

            return newLine;
        }

        /// <summary>
        /// Removes valid component declarations from a string.
        /// </summary>
        private static string RemoveComponents(string rawLine, Component component)
        {
            if(component == null)
                return rawLine;

            string filteredLine = rawLine;

            filteredLine = filteredLine.Replace(component.rawText, "");

            return filteredLine;
        }

        /// <summary>
        /// Returns true if a line is a comment (Marked with //).
        /// </summary>
        public static bool IsComment(string line)
        {
            // Remove leading and trailing whitespaces.
            string trimmed = line.Trim();

            return trimmed.StartsWith("//");
        }
    }
}
