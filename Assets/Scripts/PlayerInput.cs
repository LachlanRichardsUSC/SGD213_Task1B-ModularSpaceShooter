using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls player input and interacts with PlayerMovementScript and ShootingScript components.
/// </summary>

public class PlayerInput : MonoBehaviour
{
    private PlayerMovementScript playerMovementScript;
    private ShootingScript shootingScript;

    // Initialization
    private void Start()
    {
        // Get references to the required components.
        playerMovementScript = GetComponent<PlayerMovementScript>();
        shootingScript = GetComponent<ShootingScript>();
    }

    // Update is called once per frame
    void Update()
    {
        // Retrieve horizontal input from player
        float horizontalInput = Input.GetAxis("Horizontal");

        // Check for input and movement script
        if (playerMovementScript != null && horizontalInput != 0.0f)
        {
            // Call horizontal movement function if there's input
            playerMovementScript.horizontalMovement(horizontalInput);
        }
        
        else if (playerMovementScript == null)
        {
            // Log a message in the console if no movement script is found
            Debug.Log("Please attach the playerMovementScript component to the Player Character!");
        }

        // Check for fire input
        if (Input.GetButton("Fire1"))
        {
            // Ensure shooting script is available
            if (shootingScript != null)
            {
                shootingScript.Shoot();
            }
            else
            {
                // Log a message if shooting script is missing
                Debug.Log("Please attach the Shooting Script!");
            }
        }
    }
}
