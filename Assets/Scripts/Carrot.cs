using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Carrot : Collectable
{
    public Sprite eatenCarrot;
    public int mass = 10;
    protected override void OnCollect()
    {
        if(collected == false)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = eatenCarrot;
            Debug.Log("Grant " + mass + " mass");
        }
    }
}
