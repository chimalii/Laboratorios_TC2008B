using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Mover vehículo hacia adelante infinitamente
        //transform.Translate(0,0,1);
        transform.Translate(Vector3.forward);
    }
}
