using UnityEngine;
using System.Collections;

/// <summary>
/// Represents the projectile object that can be moved and accelerated.
/// </summary>

public class Bullet : MonoBehaviour, IMovable
{
    // The acceleration rate of the bullet projectile
    [SerializeField]
    private float acceleration = 50f;

    // The initial velocity of the bullet projectile
    [SerializeField]
    private float initialVelocity = 5f;

    // The Rigidbody2D component attached to the bullet projectile
    private Rigidbody2D rb;

    // Initialization
    void Start()
    {
        // Get the Rigidbody2D component attached to this object
        rb = GetComponent<Rigidbody2D>();
    }

    // Implements the movement behavior defined in the IMovable interface
    public void MoveForward()
    {
        rb.velocity = Vector2.up * initialVelocity;
    }

    // Applies acceleration to the bullet projectile
    public void ApplyAcceleration()
    { 
        // Calculate the force to add to the bullet projectile to simulate acceleration
        Vector2 forceToAdd = Vector2.up * acceleration * Time.deltaTime;
        rb.AddForce(forceToAdd);
    }

}
