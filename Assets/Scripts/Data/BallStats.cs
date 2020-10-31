using UnityEngine;

namespace Shanaka.BallBounce.Data
{
    [CreateAssetMenu(fileName = "Ball Stats", menuName = "Scriptable Objects/Ball/Stats", order = 3)]
    public class BallStats : ScriptableObject
    {
        public float initialForceMultiple = 100f;
        public float increaseForceMultiple = 10f;
    }
}