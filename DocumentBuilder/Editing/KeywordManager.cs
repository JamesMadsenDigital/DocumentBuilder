using System.Collections.Generic;
using System.Drawing;

namespace DocumentBuilder.Editing
{
    internal static class KeywordManager
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
                    "X",
                    "Y",
                },

                Color.PaleVioletRed
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
            foreach (KeywordGroup keywordGroup in keywordGroups)
                if (keywordGroup.HasKeyword(keyword)) return keywordGroup;

            return null;
        }
    }
}
