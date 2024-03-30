using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    private void Update()
    {
        // Retrieve horizontal input from player.
        float horizontalInput = Input.GetAxis("Horizontal");

        // Call horizontal movement function if there's input.
        if (horizontalInput != 0.0f)
        {
            playerMovementScript.horizontalMovement(horizontalInput);
        }

        // Check for fire input.
        if (Input.GetButton("Fire1"))
        {
            // Ensure shooting script is available.
            if (shootingScript != null)
            {
                shootingScript.Shoot();
            }
            else
            {
                // Log a message if shooting script is missing.
                Debug.Log("Please attach the Shooting Script!");
            }
        }
    }
}
