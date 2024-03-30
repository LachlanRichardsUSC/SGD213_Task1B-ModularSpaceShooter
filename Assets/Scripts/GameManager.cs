using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /// <summary>
    /// Moves an object implementing the IMovable interface
    /// </summary>
    /// <param name="movableObject"> The object to be moved </param>
    private void MoveObject(IMovable movableObject)
    {
        movableObject.MoveForward();
    }


}
