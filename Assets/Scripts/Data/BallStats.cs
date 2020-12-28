using UnityEngine;

namespace Shanaka.BallBounce.Data
{
    [CreateAssetMenu(fileName = "Ball Stats", menuName = "Scriptable Objects/Ball/Stats", order = 3)]
    public class BallStats : ScriptableObject
    {
        public const float initialForceMultiple = 100f;
        public const float increaseForceMultiple = 10f;
        public const float initialForce = 300f;
    }
}