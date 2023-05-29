using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_Script : MonoBehaviour
{
    public float ground_speed;
    BoxCollider2D box;
    float groundWith;
    void Start()
    {
        StartCoroutine(ground());
        box = GetComponent<BoxCollider2D>();
        groundWith = box.size.x;
    }
  

  
    IEnumerator ground()
    {
        while (true)
        {

                transform.position = new Vector2(transform.position.x - ground_speed * Time.deltaTime, transform.position.y);

                if (transform.position.x <= -groundWith)
                {
                    transform.position = new Vector2(transform.position.x + 2 * groundWith, transform.position.y);
                }
                yield return null;
        }
    }
   
}
