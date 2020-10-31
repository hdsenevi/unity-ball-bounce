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
            return colors[Random.Range(0, colors.Length)];
        }
    }
}