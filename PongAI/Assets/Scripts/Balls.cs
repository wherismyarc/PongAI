using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Balls : MonoBehaviour
{
    private float speed = 25.0f;
    private float yBoundary = 25.0f;
    private float randomMin = 1.0f;
    private float randomMax = 5.0f;
    public Vector2 direction;
    private Rigidbody ballRb;


    void Awake()
    {
        ballRb = GetComponent<Rigidbody>();
    }

    void Start() 
    {
        StartDirection();
    }

    void FixedUpdate()
    {
        BallMovement();   
    }



    private void StartDirection()
    {
        // Create random X and Y positions and set direction to those positions
        float randomX = Random.Range(randomMin, randomMax) * Random.Range(0, 2) == 0 ? -1 : 1;
        float randomY = Random.Range(randomMin, randomMax) * Random.Range(0, 2) == 0 ? -1 : 1;
        
        
        direction = new Vector2(randomX, randomY).normalized;

    }

    void BallMovement() 
    {
        ballRb.velocity = (Vector3)(direction * speed);
        SetBoundary();
    }

    

    private void SetBoundary()
    {
        if (transform.position.y > yBoundary)
        {
           direction.y = -Mathf.Abs(direction.y);
        }


        if (transform.position.y < -yBoundary)
        {
            direction.y = Mathf.Abs(direction.y);
        }

       
    }


     private void OnCollisionEnter(Collision collision)
    {
        
        ContactPoint[] contactPoints = collision.contacts;

        for (int i = 0; i < contactPoints.Length; i++)
        {

            // Take collision point normal
            Vector3 contactNormal = contactPoints[i].normal;
            Vector3 reflectedVector = Vector3.Reflect(direction, contactNormal);

            // Set direction to the reflected vector
            direction = reflectedVector;

            
        }

    }
    
}
