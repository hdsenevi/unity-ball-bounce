using System;
using System.Collections;
using System.Collections.Generic;
using Shanaka.BallBounce.Data;
using UnityEngine;

public class ScoreManager
{
    public delegate int ScoreIncreaseDelegate();
    public ScoreIncreaseDelegate OnScoreIncrease;
    private readonly ScoreData _scoreData;

    public ScoreManager(ScoreData scoreData)
    {
        _scoreData = scoreData;
    }

    public int IncreaseScore()
    {
        return _scoreData.IncreaseScore();
    }

    public void ResetScore()
    {
        _scoreData.ResetScore();
    }
}
