using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    private float maximumSpinSpeed = 200;

    // Initialization
    void Start()
    {
        // Set a random angular velocity to randomize the rotational speed of rocks.
        // The angular velocity is within a range of -maximumSpinSpeed to maximumSpinSpeed,
        // allowing rocks to rotate clockwise or counterclockwise at varying speeds.
        GetComponent<Rigidbody2D>().angularVelocity = Random.Range(-maximumSpinSpeed, maximumSpinSpeed);
    }
}
