using UnityEngine;

[RequireComponent(typeof(ColorChange))]
public class Ball : MonoBehaviour
{
    public ActivePaddle activePaddle;
    private Rigidbody2D _rigidBody;
    private ColorChange _colorChange;

    private void Awake()
    {
        InjectDependencies();
    }

    private void Start()
    {
        _rigidBody.AddForce(Vector2.right * 300f);
        _colorChange.ChangeColor();
    }

    #region Private methods
    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("OnCollisionExit2D : " + _rigidBody.velocity.normalized);
        Vector3 outsideOfBall = new Vector3(_rigidBody.velocity.normalized.x * gameObject.transform.localScale.x, 0, 0);
        Debug.DrawRay(gameObject.transform.position, _rigidBody.velocity.normalized * 100, Color.red);

        RaycastHit2D hit = Physics2D.Raycast(gameObject.transform.position + outsideOfBall,
            _rigidBody.velocity.normalized * 100f);

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
        Debug.Log("activePaddle.active : " + activePaddle.active);
    }
    #endregion

    #region Dipendancy Injection
    
    private void InjectDependencies()
    {
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
