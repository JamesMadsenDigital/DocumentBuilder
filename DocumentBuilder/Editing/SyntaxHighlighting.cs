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
        public static void Update(RichTextBox textBox, int lineIndex)
        {
            // Get current line.
            textBox.WordWrap = false;
            int cursorPosition = textBox.SelectionStart;
            int firstCharIndex = textBox.GetFirstCharIndexFromLine(lineIndex);

            if (textBox.Lines.Length < 1)
                return;

            // Text of the current line.
            string currentLine = textBox.Lines[lineIndex];

            Debug.Logs.LogDebugMessage($"Updating line {lineIndex}: {currentLine}");

            // Color entire line for comments. Reset color if not a comment.
            if (DocumentParser.IsComment(currentLine))
            {
                ChangeLineColor(textBox, lineIndex, Color.Green);
                textBox.Select(cursorPosition, 0);
                textBox.SelectionColor = Color.Black;

                // If this is a comment, we are done editing the line.
                return;
            }

            // Capture all text between square brackets.
            Regex components = new Regex("\\[(.*?)\\]");

            Match componentMatch = components.Match(currentLine);

            if (!componentMatch.Success)
            {
                ChangeLineColor(textBox, lineIndex, Color.Black);

                // Reset selection and color.
                textBox.Select(cursorPosition, 0);
                textBox.SelectionColor = Color.Black;

                return;
            }
 
            // Start index of the component in the textbox.
            int componentIndex = firstCharIndex + componentMatch.Index;

            string component = componentMatch.Value;

            textBox.Select(componentIndex, component.Length);

            textBox.SelectionColor = Color.LightGray;

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
            Regex numericChars = new Regex("[0-9]*");

            foreach (Match numericMatch in numericChars.Matches(component))
            {
                int numericIndex = componentIndex + numericMatch.Index;

                textBox.Select(numericIndex, numericMatch.Value.Length);
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

        /// <summary>
        /// Updates all syntax highlighting in the textbox.
        /// </summary>
        public static void UpdateAll(RichTextBox textBox, ProgressBar progressBar)
        {
            progressBar.Maximum = textBox.Lines.Length;

            Debug.Logs.LogDebugMessage("Updating all syntax highlighting.");

            for(int i = 0; i < textBox.Lines.Length; i++)
            {
                progressBar.Value = i;

                Update(textBox, i);
            }

            progressBar.Value = 0;
        }
    }
}
