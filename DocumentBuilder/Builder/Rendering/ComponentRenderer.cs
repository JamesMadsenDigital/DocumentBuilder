using DocumentBuilder.Builder;
using DocumentBuilder.Debug;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentBuilder
{
    internal static class ComponentRenderer
    {
        /// <summary>
        /// Draws a container and its contents onto the page.
        /// </summary>
        public static void DrawContainer(Page page, Container container)
        {
            // Width of the container.
            int width = container.width == -1 ? page.width : container.width;

            // Horizontal position of the container.
            int xPosition = GetHorizontalPosition(page, container, width);

            int initialYPosition = container.yPosition;

            // Draw each line within the container.
            for(int i = 0; i < container.lines.Count; i++)
                DrawLine(page, page.lines[container.lines[i]], initialYPosition + i, xPosition, width);
        }

        /// <summary>
        /// Draws a single line within the bounds of its parent container.
        /// </summary>
        private static void DrawLine(Page page, Line line, int yPosition, int xPosition, int width)
        {
            // Remove whitespace from start and end of line.
            string lineText = line.text.Trim();

            // Draw an HSpan if one exists.
            if(line.GetComponent("HSpan") != null)
            {
                Component hSpan = line.GetComponent("HSpan");

                char spanChar = hSpan.GetStringProperty("SpanChar", "=")[0];

                DrawHSpan(page, yPosition, xPosition, width, spanChar);

                // There should be no other text or components on a line with an HSpan.
                return;
            }

            // If line has an HSpacer
            if (line.GetComponent("HSpacer") != null)
            {
                Component hSpacer = line.GetComponent("HSpacer");

                // Spacer index cannot be greater than the line's length.
                if (lineText.Length <= hSpacer.index)
                    goto NoComponents;

                string leftSide = hSpacer.index == 0 ? " " : lineText.Substring(0, hSpacer.index - 1);
                
                string rightSide = lineText.Substring(hSpacer.index, lineText.Length - hSpacer.index);

                DrawText(page, leftSide, yPosition, xPosition);

                DrawText(page, rightSide, yPosition, xPosition + width - rightSide.Length);

                return;
            }

            NoComponents:

            DrawText(page, lineText, yPosition, xPosition);
        }

        /// <summary>
        /// Draws text from left to right on the page, starting at xPosition and YPosition.
        /// </summary>
        private static void DrawText(Page page, string text, int yPosition, int xPosition)
        {
            for(int i = 0; i < text.Length; i++)
                SetChar(page, xPosition + i, yPosition, text[i]);
        }

        /// <summary>
        /// Draws an HSpan within a container.
        /// </summary>
        private static void DrawHSpan(Page page, int yPosition, int xPosition, int width, char spanChar)
        {
            for(int i = 0; i < width; i++)
                SetChar(page, xPosition + i, yPosition, spanChar);
        }

        /// <summary>
        /// Gets the horizontal position from which a container should start drawing.
        /// </summary>
        private static int GetHorizontalPosition(Page page, Container container, int width)
        {
            // Use container's set position if it is present.
            if (container.xPosition != -1)
                return container.xPosition;

            // Use container's alignment otherwise.
            switch (container.alignment)
            {
                case "Left":
                    Logs.LogDebugMessage("Container is left aligned");
                    return 0;
                    
                case "Right":
                    Logs.LogDebugMessage("Container is right aligned");
                    return page.width - width;

                // Return a left alignment by default.
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Sets a character within page bounds to a value.
        /// </summary>
        public static void SetChar(Page page, int x, int y, char value)
        {
            // Prevent drawing on the borders or outside the page bounds.
            if (x > page.width - 1
                || y > page.height - 1
                || x < 0
                || y < 0)
                return;

            page.pageCharArray[x, y] = value;
        }
    }
}
