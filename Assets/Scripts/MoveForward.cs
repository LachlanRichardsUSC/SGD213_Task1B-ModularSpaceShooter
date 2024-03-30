using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        movable.Acceleration();
    }
}
