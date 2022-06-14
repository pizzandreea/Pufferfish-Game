using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;



public class Carrot : MonoBehaviour
{
    private int direction = -1;
    private Vector3 movement;

    void Update()
    {
        movement = new Vector3(0, direction, 0);
        transform.position = transform.position + movement * Time.deltaTime;
    }

  
}