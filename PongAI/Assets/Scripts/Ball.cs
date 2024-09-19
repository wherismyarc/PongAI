using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private float speed = 10.0f;          // Topun hareket hızı.
    private float yBoundary = 25.0f;    // Üst ve alt sınır.
    private float randomMin = 1.0f;
    private float randomMax = 5.0f;
    private Vector2 direction;   // Movement direction


   

    void Start()
    {
        SetBallDirection();

    }

    void Update()
    {
        SetBoundary();
    }


    void SetBallDirection() 
    {
        float randomX = Random.Range(randomMin , randomMax) * Random.Range(0 , 2) == 0 ? -1 : 1;
        float randomY = Random.Range(randomMin , randomMax) * Random.Range(0 , 2) == 0 ? -1 : 1;
    
        direction = new Vector2(randomX , randomY).normalized;
    }

    void SetBoundary() 
    {
        // Move ball
        transform.position += (Vector3)(direction * speed * Time.deltaTime);

    
        if (transform.position.y > yBoundary)
        {
        direction.y = -Mathf.Abs(direction.y);  
        }
    
    
        if (transform.position.y < -yBoundary)
        {
        direction.y = Mathf.Abs(direction.y);   
        }
    }
}
