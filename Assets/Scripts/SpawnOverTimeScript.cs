using UnityEngine;
using System.Collections;

public class SpawnOverTimeScript : MonoBehaviour
{
    // Object to spawn
    [SerializeField]
    private GameObject spawnObject;

    // Delay between spawns
    [SerializeField]
    private float spawnDelay = 2f;

    private Renderer ourRenderer;

    // Initialization
    void Start()
    {
        // Get the renderer component attached to this object
        ourRenderer = GetComponent<Renderer>();

        // Stop our Spawner from being visible!
        ourRenderer.enabled = false;

        // Call the given function after spawnDelay seconds
        // and then repeatedly call it after spawnDelay seconds
        InvokeRepeating("Spawn", spawnDelay, spawnDelay);
    }

    // Method to spawn objects
    void Spawn()
    {
        // Calculate the left and right bounds of the spawner
        float x1 = transform.position.x - ourRenderer.bounds.size.x / 2;
        float x2 = transform.position.x + ourRenderer.bounds.size.x / 2;

        // Randomly pick a point within the spawn object
        Vector2 spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);

        // Spawn the object at the calculated spawn point with no rotation
        Instantiate(spawnObject, spawnPoint, Quaternion.identity);
    }
}
