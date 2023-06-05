using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish_Script : MonoBehaviour
{
    Rigidbody2D fish_rb;
    [SerializeField]
    float fish_speed=2f;
    int angel;
    int max_angel = 20;
    int min_angel = -60;
    int puan = 0;

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
            yield return null;
        }
    }
    private void FixedUpdate()
    {
        fish_rotate();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Skor"))
        {
            GetScore();
            SetScore();
            Debug.Log(puan);

        }
    }
    void GetScore()
    {
        puan = puan + 1;
    }
    int SetScore()
    {
        return puan;
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
