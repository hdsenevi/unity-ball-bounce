using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Utils
{
    public static class GameColor
    {
        private static readonly Color white = Color.white;
        private static readonly Color black = Color.black;
        
        static readonly Color[] colors = { white, black };

        public static Color GetRandomColor()
        {
            return colors[UnityEngine.Random.Range(0, colors.Length)];
        }

        public static Color GetNextColor(Color color)
        {
            Color[] filteredColors = colors.Where(col => col != color).ToArray();
            
            // Return first element of filtered list of white
            return filteredColors.Length > 0 ? filteredColors.First() : white;
        }

        public static Color GetDefaultColor()
        {
            return white;
        }
    }
}