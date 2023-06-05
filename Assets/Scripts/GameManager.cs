using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static Vector2 buttonleft; 
    public static bool GameOver;
    private void Awake()
    {
        buttonleft = Camera.main.ScreenToViewportPoint(new Vector2(0, 0));
        GameOver = false;
    }
    public void GameOverr()
    {
        GameOver = true;
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
