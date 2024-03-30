using UnityEngine;
using System.Collections;

/// <summary>
/// Handles shooting behavior for the GameObject, allowing it to spawn bullets with a specified delay between shots.
/// </summary>

public class ShootingScript : MonoBehaviour
{
    // The bullet prefab to be spawned
    [SerializeField]
    private GameObject bullet;

    // The time when the last bullet was fired
    private float lastFiredTime = 0f;

    // The delay between consecutive bullet shots
    [SerializeField]
    private float fireDelay = 1f;

    // Offset to position bullets in front of the GameObject
    private float bulletOffset = 2f;

    void Start()
    {
        CalculateBulletOffset();
    }
    public void Shoot()
    {
        float currentTime = Time.time;

        // Check if enough time has passed since the last shot
        if (currentTime - lastFiredTime > fireDelay)
        {
            // Calculate spawn position for the bullet
            Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y + bulletOffset);

            // Spawn a new bullet
            Instantiate(bullet, spawnPosition, transform.rotation);

            // Update the last fired time
            lastFiredTime = currentTime;
        }
    }

    // Calculates the offset to position bullets in front of the GameObject
    private void CalculateBulletOffset()
    {
        // Half of the GameObject's size
        float gameObjectSize = GetComponent<Renderer>().bounds.size.y / 2;

        // Half of the bullet's size
        float bulletSize = bullet.GetComponent<Renderer>().bounds.size.y / 2;

        // Calculate the total offset
        bulletOffset = gameObjectSize + bulletSize;
    }
}
