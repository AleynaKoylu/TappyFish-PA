using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish_Script : MonoBehaviour
{
    Rigidbody2D fish_rb;
    [SerializeField]
    float fish_speed=5f;
    void Start()
    {
        fish_rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Fish_Movement());
       
    }

    
    IEnumerator Fish_Movement()
    {
        while (true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                fish_rb.velocity =Vector2.zero;
                fish_rb.velocity = new Vector2(fish_rb.velocity.x, fish_speed);
            }
            yield return null;
        }
    }
    void Update()
    {
        
    }

}
