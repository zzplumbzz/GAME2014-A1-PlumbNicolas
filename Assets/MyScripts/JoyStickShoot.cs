using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyStickShoot : MonoBehaviour
{
    public Transform player;
    public float speed = 10.0f;
    public GameObject arrowPrefab;

    public Transform circle;
    public Transform OuterCircle;

    private Vector2 startingPoint;
    private int leftTouch = 99;

    void Update()
    {
        shootArrow();
        int i = 0;
        while(i < Input.touchCount)
        {
            Touch t = Input.GetTouch(i);
            Vector2 touchPos = getTouchPosition(t.position) * -1;
            if (t.phase == TouchPhase.Began)
            {
                if(t.position.x > Screen.width / 2)
                {
                    shootArrow();
                }
                else
                {
                    leftTouch = t.fingerId;
                    startingPoint = touchPos;
                }
            }else if(t.phase == TouchPhase.Moved && leftTouch == t.fingerId)
            {
                Vector2 offset = touchPos - startingPoint;
                Vector2 direction = Vector2.ClampMagnitude(offset, 1.0f);

                moveCharacter(direction);

                circle.transform.position = new Vector2(OuterCircle.transform.position.x + direction.x, OuterCircle.transform.position.y + direction.y);
            }
            else if (t.phase == TouchPhase.Ended && leftTouch == t.fingerId)
            {
                leftTouch = 99;
            }
            ++i;
        }
    }
    Vector2 getTouchPosition(Vector2 touchPosition)
    {
        return GetComponent<Camera>().ScreenToWorldPoint(new Vector3(touchPosition.x, touchPosition.y, transform.position.z));
    }
    void moveCharacter(Vector2 direction)
    {
        player.Translate(direction * speed * Time.deltaTime);
    }
    void shootArrow()
    {
        GameObject a = Instantiate(arrowPrefab) as GameObject;
        a.transform.position = player.transform.position;
    }
}


