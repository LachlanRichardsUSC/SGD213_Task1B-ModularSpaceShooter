using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour, IMovable
{
    // The acceleration rate of the enemy
    [SerializeField]
    private float acceleration = 75f;

    // The initial velocity of the enemy
    [SerializeField]
    private float initialVelocity = 2f;

    // The Rigidbody2D component attached to the enemy object
    private Rigidbody2D rb;

    // initialization
    void Start()
    {
        // Get the Rigidbody2D component attached to this object
        rb = GetComponent<Rigidbody2D>();
    }

    public void MoveForward()
    {
        rb.velocity = Vector2.down * initialVelocity;
    }

    public void Acceleration()
    {
        Vector2 ForceToAdd = Vector2.down * acceleration * Time.deltaTime;
        rb.AddForce(ForceToAdd);
    }
}
