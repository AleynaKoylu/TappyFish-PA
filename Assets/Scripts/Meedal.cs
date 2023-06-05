using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meedal : MonoBehaviour
{
    public Sprite metalMedal, bronzeMedal, silverMedal, goldMedal;
    Image img;
    public Fish_Script fish_Script;
    void Start()
    {
        img = GetComponent<Image>();
        
        
    }

  
    void Update()
    {
        int gameScore = GameManager.gameScorre;
        if (gameScore > 0 && gameScore <= 1)
        {
            img.sprite = metalMedal;
        }
        if (gameScore > 1 && gameScore <= 2)
        {
            img.sprite = bronzeMedal;
        }
        if (gameScore > 2 && gameScore <= 3)
        {
            img.sprite = silverMedal;
        }
        if (gameScore > 3)
        {
            img.sprite = goldMedal;
        }
    }
}
