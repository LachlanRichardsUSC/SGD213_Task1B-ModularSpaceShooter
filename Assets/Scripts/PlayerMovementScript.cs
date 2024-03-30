using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour 
{
   // SerializeField exposes this value to the Editor, not other scripts
   [SerializeField]

    // Determines the movement speed for the Player
    private float speed = 5000f;

    private Rigidbody2D rb;

    // Initialization
    void Start() 
    {
        // Get the Rigidbody2D component attached to this object
        rb = GetComponent<Rigidbody2D>(); 
    
    }

    // Method for handling horizontal movement
    public void horizontalMovement(float horizontalInput)
    {
        // Calculate the force to add for horizontal movement.
        Vector2 forceToAdd = Vector2.right * horizontalInput * speed * Time.deltaTime;

        // Apply the calculated force to the Rigidbody2D component
        rb.AddForce(forceToAdd);
    }
}
