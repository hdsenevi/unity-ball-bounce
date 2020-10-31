using UnityEngine;

namespace Shanaka.BallBounce.Data
{
    [CreateAssetMenu(fileName = "Active Paddle", menuName = "Scriptable Objects/Active Paddle", order = 2)]
    public class ActivePaddle : ScriptableObject
    {
        public Paddle active;
    }
}