using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Collectable : MonoBehaviour
{
    // player walk into collectable
    // add collectable to player
    // delete collectable from
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();

        if (player)
        {
            player.numBanana++;
            Debug.Log("Banana collected: " + player.numBanana);
            Destroy(this.gameObject);
        }
    }
}
