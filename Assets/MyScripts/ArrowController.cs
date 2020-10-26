/*
 *  ArrowController.cs Script
    Nicolas Plumb / 101078622 / October 23 2020
    
    _Move
    moves arrows afters spawned 
    _CheckBounds
    resets arrows to the arrow pool when the leave the boundaries
    OnTriggerEnter2D
    return arrows to the arrow pool after colliding with an enemy
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    [Header("Arrow Speed")]
    public float verticalSpeed;
    [Header("Arrow Boundary")]
    public float verticalBoundary;
    [Header("Arrow Manager")]
    public ArrowManager arrowManager;
    [Header("Arrow Damage")]
    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        arrowManager = FindObjectOfType<ArrowManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(0.0f, verticalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        if (transform.position.y > verticalBoundary)
        {
            arrowManager.ReturnArrow(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        
        arrowManager.ReturnArrow(gameObject);
    }


}
