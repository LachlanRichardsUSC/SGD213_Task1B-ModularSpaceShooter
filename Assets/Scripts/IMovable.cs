using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This interface defines the contract for objects that can move in a specific direction.
/// </summary>

public interface IMovable
{
    // Method to move the object according to its defined behavior.
    void MoveForward();
    void ApplyAcceleration();
}
