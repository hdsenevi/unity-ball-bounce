using UnityEngine;

namespace Shanaka.BallBounce.Data
{
    [CreateAssetMenu(fileName = "Game Color", menuName = "Scriptable Objects/Color/Game Color", order = 1)]
    public class GameColor : ScriptableObject
    {
        public Color color = Utils.GameColor.GetDefaultColor();
    }
}