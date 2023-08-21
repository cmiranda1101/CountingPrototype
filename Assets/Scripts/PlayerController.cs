using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject ball;
    private int ballCount;
    public GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        ballCount = GameObject.FindGameObjectsWithTag("Ball").Count();
        if (ballCount == 0 & gameManager.isGameActive)
        {
            SpawnBall();
        }
    }

    public void SpawnBall()
    {
        {
            Instantiate(ball, transform.position, transform.rotation);
        }
    }
}
