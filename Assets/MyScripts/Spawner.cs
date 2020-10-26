/*
 *  Spawner.cs Script
    Nicolas Plumb / 101078622 / October 23 2020
    
    spawnObject
    intantiates a obect to spawn plus time to spawn and delay between spawns
 */

using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Spawning")]
    public GameObject spawnee;
    public bool stopSpawning;
    public float spawnTime;
    public float spawnDelay;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

   public void spawnObject()
    {
        Instantiate(spawnee, transform.position, transform.rotation);
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");

        }
    }
}
