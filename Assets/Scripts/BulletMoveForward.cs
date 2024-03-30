using UnityEngine;
using System.Collections;

public class BulletMoveForward : MonoBehaviour, IMovable
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
        // Set the initial velocity of the bullet projectile to move upward
        rb.velocity = Vector2.up * initialVelocity;
    }

    public void Acceleration()
    { 
        // Calculate the force to add to the bullet projectile to simulate acceleration
        Vector2 ForceToAdd = Vector2.up * acceleration * Time.deltaTime;

        // Apply the calculated force to the Rigidbody2D component of the bullet projectile
        rb.AddForce(ForceToAdd);
    }

}
