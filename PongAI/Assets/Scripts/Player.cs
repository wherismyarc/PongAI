using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // CONSTANTS
    private const string VERTICAL_INPUT = "Vertical";
    private const int zAxis = 0;
    private const int xAxis = 0;
    private const int verticalBoundary = 25;
    // CONSTANTS
    [SerializeField] private float speed = 20.0f;



    void Update() 
    {
        Movement();
    }
    void Movement() 
    {
        // Calculate movement and boundry

        // Calculate vertical input
        float verticalInput = Input.GetAxisRaw(VERTICAL_INPUT);
        Vector3 movement = new Vector3(xAxis, verticalInput * speed, zAxis) * Time.deltaTime;
        Vector3 newPosition = transform.position + movement;
        
        // Calculate boundry
        newPosition.y = Mathf.Clamp(newPosition.y , -verticalBoundary , verticalBoundary);

        
        transform.position = newPosition;

        // Calculate movement and boundry

        
    }
}
