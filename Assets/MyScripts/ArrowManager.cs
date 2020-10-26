/*
 *  ArrowManager.cs Script
    Nicolas Plumb / 101078622 / October 23 2020
    
    _BuildArrowPool
    builds arrow pool for shooting arrows
    GetArrow
    gets previously fired arrows and puts them back into the arrow pool
    HasArrows
    makes sure the arrow pool always has arrows
    ReturnArrow
    puts returned arrows back into the queue
    
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ArrowManager : MonoBehaviour
{
    [Header("Arrow Factory")]
    public ArrowFactory arrowFactory;
    [Header("Max Number Arrows")]
    public int MaxArrows;

    private Queue<GameObject> m_arrowPool;


    // Start is called before the first frame update
    void Start()
    {
        _BuildArrowPool();
    }

    private void _BuildArrowPool()
    {
        // create empty Queue structure
        m_arrowPool = new Queue<GameObject>();

        for (int count = 0; count < MaxArrows; count++)
        {
            var tempArrow = arrowFactory.createArrow();
            m_arrowPool.Enqueue(tempArrow);
        }
    }

    public GameObject GetArrow(Vector3 position)
    {
        var newArrow = m_arrowPool.Dequeue();
        newArrow.SetActive(true);
        newArrow.transform.position = position;
        return newArrow;
    }

    public bool HasArrows()
    {
        return m_arrowPool.Count > 0;
    }

    public void ReturnArrow(GameObject returnedArrow)
    {
        returnedArrow.SetActive(false);
        m_arrowPool.Enqueue(returnedArrow);
    }
}
