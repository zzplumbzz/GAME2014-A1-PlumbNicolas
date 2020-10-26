/*
 *  PlayerScript.cs Script
    Nicolas Plumb / 101078622 / October 23 2020
    
    FixedUpdate
    updates the joystick so the player can move
    TakeDamage
    allows the player to take damage and die then transition scenes to the game over screen
    OnTriggerEnter2D
    allows the player to pick up coins and take damage through tags
    SaveScore
    saves the players score for going to the next scene
    _FireArrow
    supposed to let the player constantly shoot
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using TMPro;


public class PlayerScript : MonoBehaviour
{
    [Header("Player Health")]
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBarScript healthBar;
    [Header("Player Speed")]
    public float speed = 5f;
    [Header("Player RigidBody")]
    public Rigidbody2D rb;
    [Header("Player Joystick")]
    public Joystick joystick;
    [Header("Player Movement")]
    public Vector2 movement;
    [Header("ArrowManager")]
    public ArrowManager arrowManager;
    [Header("Fire Delay")]
    public float fireDelay;
    [Header("Player Transform")]
    public Transform player;
    [Header("Camera")]
    public Transform target;
    public float smoothing;
    [Header("Player Bounds")]
    public Vector2 minPosition;
    public Vector2 maxPosition;
    [Header("Score")]
    public static ScoreManager instance;
    public static int score;
    






    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {


        _FireArrow();
        //inputs
        movement.x = joystick.Horizontal;
        movement.y = joystick.Vertical;
        


        if (transform.position != target.position)
        {
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);

            targetPosition.x = Mathf.Clamp(targetPosition.x, minPosition.x, maxPosition.x);
            targetPosition.y = Mathf.Clamp(targetPosition.y, minPosition.y, maxPosition.y);

            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
        }

    }

    Vector2 getTouchPosition(Vector2 touchPosition)
    {
        return GetComponent<Camera>().ScreenToWorldPoint(new Vector3(touchPosition.x, touchPosition.y, transform.position.z));
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);

    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if(currentHealth <= 0)
        {
            SaveScore();
            SceneManager.LoadScene("GameOver");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coins"))
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(20);
        }
    }

    

    void SaveScore()
    {
        PlayerPrefs.SetInt("Score", score);
    }
   

    private void _FireArrow()
    {
         
        if (Time.frameCount % 60 == 0 && arrowManager.HasArrows())
        {
            arrowManager.GetArrow(transform.position);
        }
    }
}
