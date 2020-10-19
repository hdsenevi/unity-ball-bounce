using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public ActiveColorChangeable activeColorChangeable;
    private Rigidbody2D _rigidBody;

    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        if (_rigidBody == null)
        {
            Debug.Log("RigidBody2D component not found on this gameobject");
        }
    }

    void Start()
    {
        _rigidBody.AddForce(Vector2.right * 200f);
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("OnCollisionExit2D : " + _rigidBody.velocity.normalized);
        Vector3 outsideOfBall = new Vector3(_rigidBody.velocity.normalized.x * gameObject.transform.localScale.x, 0, 0);
        Debug.DrawRay(gameObject.transform.position, _rigidBody.velocity.normalized * 100, Color.red);

        RaycastHit2D hit = Physics2D.Raycast(gameObject.transform.position + outsideOfBall, _rigidBody.velocity.normalized * 100f);
        if (hit.collider != null)
        {
            ColorChangeable colorChangeable = hit.collider.gameObject.GetComponent<ColorChangeable>();
            if (colorChangeable != null)
            {
                activeColorChangeable.active = colorChangeable;
                Debug.Log("activeColorChangeable.active : " + activeColorChangeable.active);
            }
        }
    }
}
