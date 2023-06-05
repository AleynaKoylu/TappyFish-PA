using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Fish_Script : MonoBehaviour
{
    Rigidbody2D fish_rb;
    [SerializeField]
    float fish_speed=2f;
    int angel;
    int max_angel = 20;
    int min_angel = -60;
    int puan = 0;
    public TextMeshProUGUI ScoreTxt;
    bool TouchGround;
    public GameManager gameManager;
    public Sprite FishDiedSprite;
    SpriteRenderer sp;
    Animator anm;
    int highscore;
    public TextMeshProUGUI panelscoretxt,highscoretxt;
    public ObsteclaSpawn_Script ObsteclaSpawn_Script;
    void Start()
    {
        fish_rb = GetComponent<Rigidbody2D>();
        fish_rb.gravityScale = 0;
       
        sp = GetComponent<SpriteRenderer>();
        anm = GetComponent<Animator>();
        StartCoroutine(Fish_Movement());
        
        highscore = PlayerPrefs.GetInt("highscore");
        highscoretxt.text = highscore.ToString();
        
       
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
            ScoreTxt.text = puan.ToString();
            panelscoretxt.text = puan.ToString();
            if (puan > highscore)
            {
                highscore = puan;
                highscoretxt.text = puan.ToString();
                PlayerPrefs.SetInt("highscore", highscore);
            }
            Destroy(collision.gameObject.GetComponent<BoxCollider2D>());

        }
        else if (collision.gameObject.CompareTag("Obstecla"))
        {
            gameManager.GameOverr();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            
            if (GameManager.GameOver == false)
            {
                gameManager.GameOverr();
                GameOver();
            }
            else
            {
                GameOver();
            }

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
        if (Input.GetMouseButtonDown(0)&&GameManager.GameOver==false)
        {
            if (GameManager.gameStartedd == false)
            {
                fish_rb.gravityScale = 4f;
                fish_rb.velocity = Vector2.zero;
                fish_rb.velocity = new Vector2(fish_rb.velocity.x, fish_speed);
                gameManager.GameStarted();
            }
            else
            {
                fish_rb.velocity = Vector2.zero;
                fish_rb.velocity = new Vector2(fish_rb.velocity.x, fish_speed);
            }
           
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
        if (TouchGround == false)
        {
            transform.rotation = Quaternion.Euler(0, 0, angel);
        }
        

    }
    void GameOver()
    {
        TouchGround = true;
        transform.rotation = Quaternion.Euler(0, 0, -90);
        sp.sprite = FishDiedSprite;
        anm.enabled = false;
    }

}
