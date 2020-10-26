/*
 *  Coin.cs Script
    Nicolas Plumb / 101078622 / October 23 2020
    
    OnTriggerEnter2D
    allows the player to pick up a coin and increase score 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [Header("Score Value")]
    public int coinValue = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.ChangeScore(coinValue);
        }
    }
}
