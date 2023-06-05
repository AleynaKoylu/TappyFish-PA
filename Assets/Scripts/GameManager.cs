using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static Vector2 buttonleft; 
    public static bool GameOver;
    public GameObject GameOverPanel;
    private void Awake()
    {
        buttonleft = Camera.main.ScreenToViewportPoint(new Vector2(0, 0));
        GameOver = false;
    }
    public void GameOverr()
    {
        GameOver = true;
        if (GameOver == true)
        {
            GameOverPanel.SetActive(true);

        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void Start()
    {
        
    }

    void Update()
    {
     
    }
}
