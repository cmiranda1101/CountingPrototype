using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBall : MonoBehaviour
{
    public float inputDelay;

    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        inputDelay = 0.0f;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) & inputDelay <=0)
        {
            gameObject.AddComponent<Rigidbody>();
            inputDelay = 0.5f;
        }
        inputDelay -= Time.deltaTime;

        if (transform.position.y < -5.0f)
        {
            gameManager.GameOver();
        }
    }
}
