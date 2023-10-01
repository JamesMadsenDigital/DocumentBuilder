using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentBuilder.Editing
{
    /// <summary>
    /// Group of keywords that are highlighted with a given color in the editor.
    /// </summary>
    internal class KeywordGroup
    {
        public List<string> keywords = new List<string>();

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
