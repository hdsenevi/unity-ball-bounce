using Shanaka.BallBounce.Data;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public ActivePaddle activePaddle;
    public ScoreData score;
    
    private void Update()
    {
        // ReSharper disable once Unity.PerformanceCriticalCodeNullComparison
        if (activePaddle.active != null)
        {
            scoreText.text = score.ScoreValue + " POINTS";
        }
    }
}
