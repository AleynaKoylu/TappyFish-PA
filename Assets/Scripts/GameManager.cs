using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static Vector2 buttonleft;
    private void Awake()
    {
        buttonleft = Camera.main.ScreenToViewportPoint(new Vector2(0, 0));
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
