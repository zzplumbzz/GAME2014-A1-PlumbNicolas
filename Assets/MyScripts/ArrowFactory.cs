/*
 *  ArrowFactory.cs Script
    Nicolas Plumb / 101078622 / October 23 2020
    
    createArrow
    creates arrows for the player to shoot
    
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ArrowFactory : MonoBehaviour
{
    [Header("Arrow Type")]
    public GameObject normalArrow;
    

    public GameObject createArrow(ArrowType type = ArrowType.RANDOM)
    {
        if (type == ArrowType.RANDOM)
        {
            var randomArrow = Random.Range(0, 3);
            type = (ArrowType)randomArrow;
        }

        GameObject tempArrow = null;
        switch (type)
        {
            case ArrowType.NORMAL:
                tempArrow = Instantiate(normalArrow);
                tempArrow.GetComponent<ArrowController>().damage = 10;
                break;
            
        }

        tempArrow.transform.parent = transform;
        tempArrow.SetActive(false);

        return tempArrow;
    }
}
