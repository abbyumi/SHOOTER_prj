using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int extraLives =1; //number of lives picked up
   
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        
        {
            PlayerLives.Instance.AddLives (extralives);


            //destroy the coin after pickup
            Destroy(gameObject);
        }
    }
}
