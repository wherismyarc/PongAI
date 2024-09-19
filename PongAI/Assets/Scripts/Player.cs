using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private const string VERTICAL_INPUT = "Vertical";
    private const int zAxis = 0;
    private const int xAxis = 0;
    private const int verticalBoundary = 25;
    [SerializeField] private float speed = 15.0f;



    void Update() 
    {
        Movement();
    }
    void Movement() 
    {
        float verticalInput = Input.GetAxisRaw(VERTICAL_INPUT);

        Vector3 movement = new Vector3(xAxis, verticalInput * speed, zAxis) * Time.deltaTime;
        Vector3 newPosition = transform.position + movement;

        newPosition.y = Mathf.Clamp(newPosition.y , -verticalBoundary , verticalBoundary);
        transform.position = newPosition;

        
    }
}
