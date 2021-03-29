using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAxel = 0; 
    [SerializeField] float yAxel = 1.2f;
    [SerializeField] float zAxel = 0;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAxel, yAxel, zAxel);
    }
}
