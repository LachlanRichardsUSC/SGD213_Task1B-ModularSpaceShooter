using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Moves the GameObject forward and applies acceleration using an object that implements the IMovable interface.
/// </summary>

public class MoveForward : MonoBehaviour
{
    private IMovable movable;
    
    void Start()
    {
        movable = GetComponent<IMovable>();
        movable.MoveForward();
    }

    // Update is called once per frame
    void Update()
    {
        // Applies acceleration to the Object
        movable.ApplyAcceleration();
    }
}
