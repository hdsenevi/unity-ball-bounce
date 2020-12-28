using System;
using System.Collections;
using System.Collections.Generic;
using Shanaka.BallBounce.Data;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ScoreManager scoreManager { get; private set; }
    public ScoreData scoreData;

    private void Awake()
    {
        scoreManager = new ScoreManager(scoreData);
    }
}