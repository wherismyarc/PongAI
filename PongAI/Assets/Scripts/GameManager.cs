using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    [SerializeField] Transform Player;
    [SerializeField] Transform Enemy;
    void Awake() 
    {
        CreateGame();
    }

    void CreateGame() 
    {
        Instantiate(Player , transform.position , Quaternion.identity);
    }
}
