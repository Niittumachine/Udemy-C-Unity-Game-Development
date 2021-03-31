using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Liikkumisnopeus arvoja
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float rotateSpeed = 10f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        ProcessRotation();
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to Team MacArthur's game. Use WASD or arrow keys to control your character. Rotate by using Q and E. Hit enemies with your Bo-Pole, don't touch enemies or spikes.");  
    }

    //WASD ja nuolinäppäin liikkuminen
    void PlayerMove()
    {
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime *moveSpeed;
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime *moveSpeed;

        transform.Translate(xValue,0,zValue);
    }
    

    //Sivuttain kääntyminen hiiren näppäimillä
    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            ApplyRotation(rotateSpeed);
        }
        else if (Input.GetKey(KeyCode.Mouse0))
        {
            ApplyRotation(-rotateSpeed);
        }
    }
    void ApplyRotation(float rotationThisFrame)
    {
        transform.Rotate(Vector3.up * rotationThisFrame * Time.deltaTime);
    }

}