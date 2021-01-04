using System;
using Shanaka.BallBounce.Data;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public Text debugText;
    public ActivePaddle activePaddle;
    public ScoreData score;
    
    private void Update()
    {
        // ReSharper disable once Unity.PerformanceCriticalCodeNullComparison
        if (activePaddle.active != null)
        {
            debugText.text = "Active : " + activePaddle.active.gameObject.name;
        }
        
        scoreText.text = score.ScoreValue + " POINTS";
    }
}
