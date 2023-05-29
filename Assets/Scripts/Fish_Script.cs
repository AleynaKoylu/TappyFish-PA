using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish_Script : MonoBehaviour
{
    Rigidbody2D fish_rb;
    [SerializeField]
    float fish_speed=5f;
    int angel;
    int max_angel = 20;
    int min_angel = -60;

    void Start()
    {
        fish_rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Fish_Movement());
       
    }

    
    IEnumerator Fish_Movement()
    {
        while (true)
        {
            fish_tap();
            fish_rotate();
            yield return null;
        }
    }
    void fish_tap()
    {
        if (Input.GetMouseButtonDown(0))
        {
            fish_rb.velocity = Vector2.zero;
            fish_rb.velocity = new Vector2(fish_rb.velocity.x, fish_speed);
        }
    }
    void fish_rotate()
    {
        if (fish_rb.velocity.y > 0)
        {
            if (angel <= max_angel)
            {
                angel = angel + 4;
            }
        }
        else if (fish_rb.velocity.y < -1.2)
        {
            if (angel >= min_angel)
            {
                angel = angel - 2;
            }
        }
        transform.rotation = Quaternion.Euler(0, 0, angel);

    }
    

}
