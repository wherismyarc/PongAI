using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform Enemy;
    [SerializeField] private Transform Ball;
    void OnEnable() 
    {
        SetWorld();
    }

    void SetWorld() 
    {
        // Player setup
        Vector3 newPos = new Vector3(60, 0, 0);
        Instantiate(Player, newPos, Quaternion.identity);
        // Player setup


        // Enemy Setup
        Instantiate(Enemy, -newPos, Quaternion.identity);
        // Enemy Setup


        // Sphere Setup
        Instantiate(Ball , Vector3.zero , Quaternion.identity);
        // Sphere Setup
    }

    
}
