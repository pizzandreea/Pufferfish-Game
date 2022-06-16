using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class Player : Collidable
{
    //INHERITED
    //private BoxCollider2D boxCollider;
    private Vector3 moveDelta;
    private RaycastHit2D hit;
    public float playerMass  = 1.06f;


    protected override void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate()
    {

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        // Reset MoveDelta
        moveDelta = new Vector3(x, y, 0);
        Vector3 currentScale = transform.localScale;

        if (moveDelta.x > 0)
            transform.localScale = new Vector3(Math.Abs(currentScale.x),currentScale.y, currentScale.z);

        else if (moveDelta.x < 0)
            transform.localScale = new Vector3(-Math.Abs(currentScale.x), currentScale.y, currentScale.z);


        //make sure we can move in y
        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(0, moveDelta.y), Mathf.Abs(moveDelta.y * Time.deltaTime), LayerMask.GetMask("Player","Blocking"));
        if(hit.collider == null)
        {
            //make fish move
            transform.Translate(0, moveDelta.y * Time.deltaTime * 2, 0);
        }

        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(moveDelta.x, 0), Mathf.Abs(moveDelta.x * Time.deltaTime), LayerMask.GetMask("Player", "Blocking"));
        if (hit.collider == null)
        {
            //make fish move
            transform.Translate(moveDelta.x * Time.deltaTime * 2, 0, 0);
        }



        //Debug.Log(x);
        //Debug.Log(y);
    }

    protected void ReceiveMass(float size)
    {
        Vector3 currentScale = transform.localScale;

        if (size < playerMass)
        {
            playerMass = playerMass + 1.05f;
            transform.localScale = new Vector3(Math.Abs(currentScale.x * 1.05f), currentScale.y * 1.05f, currentScale.z);
        }
        else
        {
            
            Destroy(gameObject);
            //game over
        }

    }

 



}
