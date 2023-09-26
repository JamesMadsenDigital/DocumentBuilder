using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DocumentBuilder.Logs;

namespace DocumentBuilder.Forms.MainForm
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
            if (IsComment(currentLine))
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

            MatchCollection componentMatches = components.Matches(currentLine);

            foreach (Match componentMatch in componentMatches)
            {
                // Start index of the component in the textbox.
                int componentIndex = firstCharIndex + componentMatch.Index;

                string component = componentMatch.Value;

                // Match [ ] ( ) =.
                Regex closures = new Regex(@"\[|\]|\(|\)|=");

                foreach (Match closureMatch in closures.Matches(component))
                {
                    LogManager.LogDebugMessage($"closure detected: {closureMatch.Value}");

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

                    KeywordGroup keywordGroup = KeyWords.KeywordMatch(token);

                    Color tokenColor = Color.Red;

                    if (keywordGroup != null)
                        tokenColor = keywordGroup.keywordColor;

                    textBox.Select(tokenIndex, token.Length);
                    textBox.SelectionColor = tokenColor;
                }

                // Match all numeric characters.
                Regex numericChars = new Regex("[0-9]");

                // Tabs offset the color index on numbers for some reason.
                int tabCount = currentLine.Count(ch => ch == '\t');

                foreach (Match numericMatch in numericChars.Matches(currentLine))
                {
                    int numericIndex = componentIndex + numericMatch.Index;

                    textBox.Select(numericIndex - tabCount, 1);
                    textBox.SelectionColor = Color.Purple;
                }
            }

            // Reset selection and color.
            textBox.Select(cursorPosition, 0);
            textBox.SelectionColor = Color.Black;
        }

        /// <summary>
        /// Returns true if a line is a comment (Marked with // at start of line).
        /// </summary>
        private static bool IsComment(string line)
        {
            // Remove leading and trailing whitespaces.
            string trimmed = line.Trim();

            return trimmed.StartsWith("//");
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

    /// <summary>
    /// Manages coloring of keywords.
    /// </summary>
    internal static class KeyWords
    {
        // List of keywords and their colorings.
        private static List<KeywordGroup> keywordGroups = new List<KeywordGroup>
        {
            // Properties
            new KeywordGroup
            (
                new List<string>
                {
                    "Alignment",
                    "Width",
                    "Height",
                    "SpanChar",
                },

                Color.Plum
            ),

            // Alignments
            new KeywordGroup
            (
                new List<string>
                {
                    "Left",
                    "Right"
                },
                
                Color.LightSeaGreen
            )
        };

        /// <summary>
        /// Adds a keyword to the list based on color. Creates new group if none exist for color.
        /// </summary>
        public static void AddByColor(string keywordName, Color keywordColor)
        {
            KeywordGroup existingGroup = keywordGroups.Find(x => x.keywordColor == keywordColor);

            if (existingGroup == null)
            {
                keywordGroups.Add(new KeywordGroup(new List<string> { keywordName }, keywordColor));
                return;
            }

            existingGroup.keywords.Add(keywordName);
        }

        /// <summary>
        /// Returns a keyword group if the inputted keyword matches one in a group.
        /// </summary>
        public static KeywordGroup KeywordMatch(string keyword)
        {
            foreach( KeywordGroup keywordGroup in keywordGroups )
                if(keywordGroup.HasKeyword(keyword)) return keywordGroup;

            return null;
        }
    }

    /// <summary>
    /// Represents a group of keywords that are highlighted with a given color.
    /// </summary>
    internal class KeywordGroup
    {
        public List<string> keywords = new List<string>();

        // Should this keyword color the entire line if detected?
        public bool colorLine = false;

        public Color keywordColor = Color.Black;

        /// <summary>
        /// Parameterized constructor for a KeywordGroup.
        /// </summary>
        public KeywordGroup(List<string> keywords, Color keywordColor)
        {
            this.keywords = keywords;
            this.keywordColor = keywordColor;
        }

        /// <summary>
        /// Returns true if this group contains a keyword.
        /// </summary>
        public bool HasKeyword(string keyword)
        {
            return keywords.Contains(keyword);
        }
    }
}
