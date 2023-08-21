using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBasket : MonoBehaviour
{
    private float zBound = 13.0f;
    public float speed;
    private float minSpeed = 3.5f;
    private float maxSpeed = 10.0f;
    private bool moveRight;
    // Start is called before the first frame update
    void Start()
    {
        moveRight = true;
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.z >= zBound)
        {
            moveRight = false;
        }

        if(transform.position.z <= -zBound)
        {
            moveRight = true;
        }

        if (moveRight == true)
        {
            MoveRight();
        }

        if (moveRight == false)
        {
            MoveLeft();
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Ball"))
        {
            Destroy(other.gameObject);
            speed = Random.Range(minSpeed, maxSpeed);
        }
    }

    private void MoveRight()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void MoveLeft()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
