using DocumentBuilder.Debug;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentBuilder.Builder
{
    internal static class ContainerBuilder
    {
        /// <summary>
        /// Builds all types of containers onto the page.
        /// </summary>
        public static void BuildContainers(ref Page page)
        {
            for(int i = 0; i < page.lines.Count; i++)
            {
                // Get the component.
                Component container = page.lines[i].GetComponent("Container");

                if (container == null)
                    continue;

                int endIndex = GetContainerEnd(i, "EndContainer", page.lines);

                // If a valid end to the container was found.
                if(endIndex != -1)
                {
                    // Add new container to page.
                    page.containers.Add(new Container(
                        // Position on page.
                        container.GetIntProperty("X", -1),
                        container.GetIntProperty("Y", 0),
                        // Width of container.
                        container.GetIntProperty("Width", -1),
                        // Alignment on page.
                        container.GetStringProperty("Alignment", "Left"),
                        // Indexes of lines within container.
                        GetContainerLines(i, endIndex)
                    ));

                    i = endIndex;
                }
            }
        }

        /// <summary>
        /// Returns the ending index of a container. Returns -1 if no matching end tag is found.
        /// </summary>
        private static int GetContainerEnd(int startIndex, string endTag, List<Line> lines)
        {
            // Iterate from the bottom up.
            for (int i = startIndex; i < lines.Count; i++)
            {
                Component endContainer = lines[i].GetComponent(endTag);

                if (endContainer == null)
                    continue;

                return i;
            }

            return -1;
        }

        /// <summary>
        /// Removes lines that are not inside of a container.
        /// </summary>
        /// <param name="page"></param>
        private static void TrimLines(ref Page page)
        {
            List<int> containerLines = new List<int>();

            foreach(Container container in page.containers)
                foreach (int containerLine in container.lines)
                    containerLines.Add(containerLine);

            for(int i = 0; i < page.lines.Count; i++)
            {
                if (!containerLines.Contains(i))
                {
                    Logs.LogDebugMessage($"Removing line at {i}.");
                    page.lines.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// Adds indexes for all lines between the start and end index of a container.
        /// </summary>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        private static List<int> GetContainerLines(int startIndex, int endIndex)
        {
            List<int> lineIndexes = new List<int>();    

            for(int i = startIndex; i < endIndex; i++)
            {
                lineIndexes.Add(i);
            }

            return lineIndexes;
        }
    }
}
