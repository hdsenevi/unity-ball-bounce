using System;
using Shanaka.BallBounce.Data;
using UnityEngine;

[RequireComponent(typeof(ColorChange))]
public class Ball : MonoBehaviour
{
    public ActivePaddle activePaddle;
    public GameColor ballGameColor;
    public BallStats ballStats;
    private Rigidbody2D _rigidBody;
    private ColorChange _colorChange;
    private GameManager _gameManager;

    private void Awake()
    {
        InjectDependencies();
    }

    private void Start()
    {
        // TODO / REFACTOR : Refactor this to a separate function later
        _rigidBody.AddForce(Vector2.right * BallStats.initialForce);
    }

    #region Private methods
    private void ChangeColor()
    {
        ballGameColor.color = _colorChange.ChangeColor();
    }

    private void OnCollisionEnter2D(Collision2D otherCollision)
    {
        Paddle paddle = otherCollision.gameObject.GetComponent<Paddle>();
        
        // Guard
        if (paddle == null)
        {
            return;
        }

        // Play sound
        _gameManager.soundManager.PlayRandomColliderSound();
        
        if (ballGameColor.color == paddle.GetCurrentColor())
        {
            _gameManager.scoreManager.IncreaseScore();
        } else 
        {
            _gameManager.scoreManager.ResetScore();
            
            // // TODO / REFACTOR : Refactor this to a separate function later
            // Vector2 movingDirection = _rigidBody.velocity.normalized;
            // _rigidBody.velocity = Vector2.zero;
            // _rigidBody.AddForce(movingDirection * BallStats.initialForce);
            //
            // // TODO : maybe not the best thing to do atm
            // _gameManager.RestartGame();
        }
    }

    private void OnCollisionExit2D(Collision2D otherCollision)
    {
        Vector3 outsideOfBall = new Vector3(_rigidBody.velocity.normalized.x * gameObject.transform.localScale.x, 0, 0);
        RaycastHit2D hit = Physics2D.Raycast(gameObject.transform.position + outsideOfBall,
            _rigidBody.velocity.normalized * BallStats.initialForceMultiple);

        // Guard
        if (hit.collider == null)
        {
            return;
        }

        Paddle paddle = hit.collider.gameObject.GetComponent<Paddle>();

        // Guard
        if (paddle == null)
        {
            return;
        }

        activePaddle.active = paddle;
        ChangeColor();
        ChangeSpeed();
    }

    private void ChangeSpeed()
    {
        _rigidBody.AddForce(_rigidBody.velocity.normalized * BallStats.increaseForceMultiple);
    }

    #endregion

    #region Dipendancy Injection
    
    private void InjectDependencies()
    {
        if (activePaddle == null)
        {
            Debug.LogError("activePaddle asset not found");
        }
        
        if (ballGameColor == null)
        {
            Debug.LogError("ballGameColor asset not found");
        }
        
        if (ballStats == null)
        {
            Debug.LogError("ballStats asset not found");
        }

        _gameManager = GameObject.FindWithTag("Managers").GetComponent<GameManager>();
        if (_gameManager == null)
        {
            Debug.LogError("GameManager component not found on a game object with tag 'Managers'");
        }
        
        _rigidBody = GetComponent<Rigidbody2D>();
        if (_rigidBody == null)
        {
            Debug.LogError("RigidBody2D component not found on this game object");
        }

        _colorChange = GetComponent<ColorChange>();
        if (_colorChange == null)
        {
            Debug.LogError("ColorChange component not available");
        }
    }
    
    #endregion
}
