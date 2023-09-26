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
                ChangeLineColor(textBox, currentLineIndex, Color.Black);

            // Color brackets and parentheses.
            Regex closures = new Regex("(\\(\\d+\\))");

            MatchCollection closureMatches = closures.Matches(currentLine);

            foreach(Match closure in closureMatches)
            {
                int charIndex = firstCharIndex + closure.Index;
                textBox.Select(charIndex, 1);
                textBox.SelectionColor = Color.LightGray;
            }

            // Color numbers between parentheses and brackets
            Regex closureNumbers = new Regex(@"");

            MatchCollection closureNumberMatches = closureNumbers.Matches(currentLine);

            foreach(Match closureNumber in closureNumberMatches)
            {
                int charIndex = firstCharIndex + closureNumber.Index;

                textBox.Select(charIndex, closureNumber.Value.Length);
                textBox.SelectionColor = Color.Purple;

            }

            // Color keywords.
            Regex keywords = new Regex(@"\w*");

            MatchCollection keywordMatches = keywords.Matches(currentLine);

            foreach(Match keyword in keywordMatches)
            {
                int charIndex = firstCharIndex + keyword.Index;

                KeywordGroup groupMatch = KeyWords.KeywordMatch(keyword.Value);

                if (groupMatch == null)
                    continue;

                textBox.Select(charIndex, keyword.Value.Length);
                textBox.SelectionColor = groupMatch.keywordColor;
            }




            // Reset selection and color.
            textBox.Select(cursorPosition, 0);
            textBox.SelectionColor = Color.Black;

            /*
          int selectionStart = textBox.SelectionStart;
          int selectionLength = textBox.SelectionLength;

          // Split line into tokens.
          Regex r = new Regex("([ \\t{}();])");

          string[] tokens = r.Split(currentLine);






          
          foreach(string token in tokens)
          {
              textBox.SelectionStart = index;
              textBox.SelectionLength = token.Length;
              textBox.SelectionColor = Color.Black;

              // Check if token is keyword.
              KeywordGroup tokenMatch = KeyWords.KeywordMatch(token);

              if (tokenMatch == null)
                  continue;

              // Set color of keyword.
              textBox.SelectionColor = tokenMatch.keywordColor;
          }

          // Restore previous selection.
          textBox.SelectionStart = selectionStart;
          textBox.SelectionLength = selectionLength;
          */
        }

        /// <summary>
        /// Returns true if a line is a comment.
        /// </summary>
        private static bool IsComment(string line)
        {
            return line.StartsWith("//");
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
            // Page start and end.
            new KeywordGroup
            (
                new List<string>
                {
                    "Page",
                    "EndPage"
                },

                false,

                Color.Blue
            ),

            // ColumnGroup start and end.
            new KeywordGroup
            (
                new List<string>
                {
                    "ColumnGroup",
                    "EndColumnGroup",
                },

                false,

                Color.CornflowerBlue
            ),

            // Column start and end.
            new KeywordGroup
            (
                new List<string>
                {
                    "Column",
                    "EndColumn"
                },

                false,

                Color.BlueViolet
            ),

            // HSpans.
            new KeywordGroup
            (
                new List<string>
                {
                    "HSpan"
                },

                true,

                Color.HotPink
            ),

            // VSpacers and HSpacers.
            new KeywordGroup
            (
                new List<string>
                {
                    "HSpacer",
                    "VSpacer"
                },

                false,

                Color.Violet
            ),

            // Parameters.
            new KeywordGroup
            (
                new List<string>
                {
                    "Alignment",
                    "Width",
                    "Height",
                },

                false,

                Color.Plum
            ),


        };

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
        public KeywordGroup(List<string> keywords, bool colorLine, Color keywordColor)
        {
            this.keywords = keywords;
            this.colorLine = colorLine;
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
