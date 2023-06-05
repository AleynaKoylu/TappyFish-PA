using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsteclaSpawn_Script : MonoBehaviour
{
    public GameObject obstacle;
    public float maxy, miny;
    float randy;

    void Start()
    {
       
        StartCoroutine(Obstaclecl());   
    }

    IEnumerator Obstaclecl()
    {
        while (true)
        {
            if (GameManager.GameOver == false)
            {
                InstantiateObstacles();
            }
            yield return new WaitForSeconds(3.5f);
        }
    }
    void Update()
    {
        
    }
    public void InstantiateObstacles()
    {
        GameObject new_obstacle = Instantiate(obstacle);
        randy = Random.Range(maxy, miny);
        new_obstacle.transform.position = new Vector2(transform.position.x, randy);

    }
}
