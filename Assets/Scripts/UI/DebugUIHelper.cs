using Shanaka.BallBounce.Data;
using UnityEngine;
using UnityEngine.UI;

public class DebugUIHelper : MonoBehaviour
{
    public Text text;
    public ActivePaddle activePaddle;

    private void Update()
    {
        // ReSharper disable once Unity.PerformanceCriticalCodeNullComparison
        if (activePaddle.active != null)
        {
            text.text = activePaddle.active.name;
        }
    }
}
