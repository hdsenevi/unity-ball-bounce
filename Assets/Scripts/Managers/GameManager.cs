using System;
using System.Collections;
using System.Collections.Generic;
using Shanaka.BallBounce.Data;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public ScoreManager scoreManager { get; private set; }
    public SoundManager soundManager { get; private set; }
    public ScoreData scoreData;

    private void Awake()
    {
        scoreManager = new ScoreManager(scoreData);
    }

    private void Start()
    {
        soundManager = GetComponent<SoundManager>();
        if (soundManager == null)
        {
            Debug.LogError("SoundManager component not available on this GameObject");
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}