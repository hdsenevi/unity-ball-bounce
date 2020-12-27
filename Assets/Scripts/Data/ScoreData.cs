using System;
using UnityEngine;
    
namespace Shanaka.BallBounce.Data
{
    [CreateAssetMenu(fileName = "Score", menuName = "Scriptable Objects/Score", order = 1)]
    public class ScoreData: ScriptableObject
    {
        private int _score;

        public int ScoreValue
        {
            get => _score;
            set => _score = value;
        }

        public int IncreaseScore()
        {
            return ++_score;
        }

        public int ResetScore()
        {
            _score = 0;
            return _score;
        }
    }
}