/*
 *  EnemyFollow.cs Script
    Nicolas Plumb / 101078622 / October 23 2020
    
    FixedUpdate
    updates the players transform for the enemy AI
    moveCharacter
    moves enemy character 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    [Header("Player")]
    public Transform Player;
    [Header("Move Speed")]
    public float moveSpeed = 0.8f;
    [Header("RigidBody")]
    private Rigidbody2D rb;
    [Header("Movement")]
    private Vector2 movement;


    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Player.position - transform.position;
        float angle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
       // rb.rotation = angle;
        direction.Normalize();
        movement = direction;

        
    }

    private void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

    


}
