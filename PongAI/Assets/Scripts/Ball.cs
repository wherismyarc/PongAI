using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private float speed = 5.0f;          // Topun hareket hızı.
    private float yBoundary = 25.0f;    // Üst ve alt sınır.
    private float random = 5.0f;
    private Vector2 direction;   // Movement direction


   

void Start()
{
    direction = new Vector2(Random.Range(random, -random), Random.Range(random, -random));
    // Başlangıç yönünü normalize edin.
    direction.Normalize();

}

void Update()
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
