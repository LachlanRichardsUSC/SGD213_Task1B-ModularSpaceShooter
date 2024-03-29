using UnityEngine;
using System.Collections;

public class EnemyMoveForward : MonoBehaviour, IMovable
{
    // The acceleration rate of the enemy.
    private float acceleration = 75f;

    // The initial velocity of the enemy.
    private float initialVelocity = 2f;

    // The Rigidbody2D component attached to the enemy object.
    private Rigidbody2D rb;

    // initialization
    void Start()
    {
        // Get the Rigidbody2D component attached to this object.
        rb = GetComponent<Rigidbody2D>();

        // Set the initial velocity of the enemy to move downward.
        rb.velocity = Vector2.down * initialVelocity;
    }

    // Implements the movement behavior defined in the IMovable interface.
    public void Move()
    {
        // Calculate the force to add to the enemy to simulate acceleration.
        Vector2 ForceToAdd = Vector2.down * acceleration * Time.deltaTime;

        // Apply the calculated force to the Rigidbody2D component of the enemy.
        rb.AddForce(ForceToAdd);
    }
}
