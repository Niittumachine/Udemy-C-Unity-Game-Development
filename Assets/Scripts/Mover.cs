using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    // kommentin kirjoittaminen on jo arki päiväistä
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction() 
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls or obstacles!");
    }

    void MovePlayer()
    {
        //Input.GetAxis mahdollistaa ohjaamisen WASD näppäimillä
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime *moveSpeed;
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime *moveSpeed;

        transform.Translate(xValue,0,zValue);
    }
}
