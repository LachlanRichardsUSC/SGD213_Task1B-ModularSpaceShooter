using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Define an enumeration to represent different types of tag lists
public enum TagListType
{
    Blacklist, 
    Whitelist  
}

public class DestroyedOnCollision : MonoBehaviour
{
    [SerializeField] private TagListType tagListType = TagListType.Blacklist;
    [SerializeField] private List<string> tags = new List<string>();

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the tag of the colliding object is in the list of tags
        bool tagInList = tags.Contains(other.gameObject.tag);

        // Use a switch statement to determine behavior based on tagListType
        switch (tagListType)
        {
            // If tagListType is Blacklist...
            case TagListType.Blacklist:
                // Check if the tag is in the list
                if (tagInList)
                {
                    // If so, destroy the game object
                    Destroy(gameObject);
                }
                // Exit the switch statement
                break;

            // If tagListType is Whitelist...
            case TagListType.Whitelist:
                // Check if the tag is NOT in the list
                if (!tagInList)
                {
                    // If so, destroy the game object
                    Destroy(gameObject);
                }
                // Exit the switch statement
                break;
        }
    }
}
