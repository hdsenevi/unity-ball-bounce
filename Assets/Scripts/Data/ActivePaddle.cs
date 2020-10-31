using UnityEngine;

[CreateAssetMenu(fileName = "Active Paddle", menuName = "Scriptable Objects/Active Paddle", order = 1)]
public class ActivePaddle : ScriptableObject
{
    public Paddle active;
}
