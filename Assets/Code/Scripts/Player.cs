using System.Security.Cryptography;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;   

public class Player : MonoBehaviour
{
    public Inventory inventory;

    private void Awake()
    {
        inventory = new Inventory(21);
    }

    // Remove the item from the player's inventory
    // and spawn it in the world
    public void DropItem(Item item)
    {
        // Initialize the item's spawn location
        Vector2 spawnLocation = transform.position;

        // Create a random offset for the item to spawn
        Vector2 spawnOffSet;
        do
        {
            spawnOffSet = Random.insideUnitCircle * 2.25f;
        } while (spawnOffSet.magnitude < 1.75f); // Make sure the item doesn't spawn too close to the player

        // Instantiate the item at the player's location
        Item droppedItem = Instantiate(item, spawnLocation + spawnOffSet, 
            Quaternion.identity);

        // Add force to the item to make it move
        droppedItem.rb2d.AddForce(spawnOffSet * 0.5f, ForceMode2D.Impulse);
    }
}

