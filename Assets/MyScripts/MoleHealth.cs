/*
 *  MoleHealth.cs Script
    Nicolas Plumb / 101078622 / October 23 2020
    
    TakeDamage
    enables the player to kill mole enemy
    OnTriggerEnter2D
    allows the mole to be damaged and killed when arrow collides
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MoleHealth : MonoBehaviour
{
    [Header("Mole Health")]
    public int moleMaxHealth = 10;
    public int moleCurrentHealth;
    [Header("Arrow")]
    public GameObject arrowPrefab;

    public static ScoreManager instance;
    public TextMeshProUGUI text;
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        moleCurrentHealth = moleMaxHealth;
        
    }


    void TakeDamage(int damage)
    {
        moleCurrentHealth -= damage;
        
        if (moleCurrentHealth <= 0)
        {
            Destroy(gameObject);
            //score += coinValue;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("Arrow"))
        {
            TakeDamage(10);
        }
    }
}
