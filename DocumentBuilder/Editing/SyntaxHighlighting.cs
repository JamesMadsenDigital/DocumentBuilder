using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;
using DocumentBuilder.Parsing;

namespace DocumentBuilder.Editing
{
    internal static class SyntaxHighlighting
    {
        /// <summary>
        /// Updates the syntax highlighting on the editor textbox.
        /// </summary>
        public static void Update(RichTextBox textBox)
        {
            if (textBox.SelectionStart == 0)
                return;

            // Get current line.
            textBox.WordWrap = false;
            int cursorPosition = textBox.SelectionStart;
            int currentLineIndex = textBox.GetLineFromCharIndex(cursorPosition);
            int firstCharIndex = textBox.GetFirstCharIndexFromLine(currentLineIndex);

            // Text of the current line.
            string currentLine = textBox.Lines[currentLineIndex];
            textBox.WordWrap = false;

            // Color entire line for comments. Reset color if not a comment.
            if (DocumentParser.IsComment(currentLine))
            {
                ChangeLineColor(textBox, currentLineIndex, Color.Green);
                textBox.Select(cursorPosition, 0);
                textBox.SelectionColor = Color.Black;

                // If this is a comment, we are done editing the line.
                return;
            }
            else
            {
                ChangeLineColor(textBox, currentLineIndex, Color.Black);
            }

            // Capture all text between square brackets.
            Regex components = new Regex("\\[(.*?)\\]");

            Match componentMatch = components.Match(currentLine);

            // Start index of the component in the textbox.
            int componentIndex = firstCharIndex + componentMatch.Index;

            string component = componentMatch.Value;

            // Match [ ] ( ) =.
            Regex closures = new Regex(@"\[|\]|\(|\)|=");

            foreach (Match closureMatch in closures.Matches(component))
            {
                // Start index of the closure in the textbox.
                int closureIndex = componentIndex + closureMatch.Index;

                textBox.Select(closureIndex, 1);

                textBox.SelectionColor = Color.LightGray;
            }

            // Match all word characters.
            Regex tokens = new Regex(@"[a-zA-Z]*");

            foreach (Match tokenMatch in tokens.Matches(component))
            {
                string token = tokenMatch.Value;

                int tokenIndex = componentIndex + tokenMatch.Index;

                KeywordGroup keywordGroup = KeywordManager.KeywordMatch(token);

                Color tokenColor = Color.Red;

                if (keywordGroup != null)
                    tokenColor = keywordGroup.keywordColor;

                textBox.Select(tokenIndex, token.Length);
                textBox.SelectionColor = tokenColor;
            }

            // Match all numeric characters.
            Regex numericChars = new Regex("[0-9]");

            foreach (Match numericMatch in numericChars.Matches(component))
            {
                int numericIndex = componentIndex + numericMatch.Index;

                textBox.Select(numericIndex, 1);
                textBox.SelectionColor = Color.Purple;
            }
            
            // Reset selection and color.
            textBox.Select(cursorPosition, 0);
            textBox.SelectionColor = Color.Black;
        }

        /// <summary>
        /// Changes the color of an entire line in the text box.
        /// </summary>
        private static void ChangeLineColor(RichTextBox textBox, int currentLineIndex, Color color)
        {
            int currentLineLength = textBox.Lines[currentLineIndex].Length;

            textBox.Select(textBox.GetFirstCharIndexFromLine(currentLineIndex), currentLineLength);
            textBox.SelectionColor = color;
        }
    }
}
