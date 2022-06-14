/*
using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;



public class Fish : MonoBehaviour
{
    protected BoxCollider2D boxCollider;
    protected Vector3 moveDelta;
    protected RaycastHit2D hit;
    protected float ySpeed = 0.75f;
    protected float xSpeed = 1.07f;


    private virtual void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }


    private void FixedUpdate()
    {

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        


    }

    protected virtual void UpdateMotor(Vector3 input)
    {

        moveDelta = new Vector3(x, y, 0);

        if (moveDelta.x > 0)
            transform.localScale = Vector3.one;
        else if (moveDelta.x < 0)
            transform.localScale = new Vector3(-1, 1, 1);

        transform.Translate(moveDelta * Time.deltaTime);
    }
}*/