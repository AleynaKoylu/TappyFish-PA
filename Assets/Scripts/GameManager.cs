using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static Vector2 buttonleft; 
    public static bool GameOver;
    public GameObject GameOverPanel;
    public static bool gameStartedd;
    public GameObject startPanel;
    public GameObject score;
    public static int gameScorre;
    public Fish_Script fish_Script;
    
    private void Awake()
    {
        buttonleft = Camera.main.ScreenToViewportPoint(new Vector2(0, 0));
        GameOver = false;
    }
    public void GameOverr()
    {
        GameOver = true;
        GameOverPanel.SetActive(true);
        gameScorre = fish_Script.GetScore();
        score.SetActive(false);
      
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void Start()
    {
        gameStartedd = false;
    }
    public void GameStarted()
    {
        gameStartedd = true;
        startPanel.SetActive(false);
    }
    void Update()
    {
     
    }
}
