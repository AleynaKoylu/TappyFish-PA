using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMovementObstecla_Script : MonoBehaviour
{
    public float ground_speed;
    float obsteclawith;
   
    void Start()
    {
        StartCoroutine(ground());
        obsteclawith = GameObject.FindGameObjectWithTag("Obstecla").GetComponent<BoxCollider2D>().size.x;
    }



    IEnumerator ground()
    {
        while (true)
        {
            
            transform.position = new Vector2(transform.position.x - ground_speed * Time.deltaTime, transform.position.y);

            destroyy();
            yield return null;
        }
    }
   
    void destroyy()
    {
        if (gameObject.transform.position.x <GameManager.buttonleft.x-obsteclawith)
        {
            Destroy(gameObject);
        }
    }
}
