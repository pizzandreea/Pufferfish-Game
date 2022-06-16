using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishRight : MonoBehaviour
{
    private int direction = 1;
    private Vector3 movement;

    void Update()
    {
        movement = new Vector3(direction, 0, 0);
        transform.position = transform.position + movement * Time.deltaTime;
    }

    /*  private void OnCollisionStay(Collision coll)
      {
          if (coll.gameObject.CompareTag("Box"))
              direction = direction * -1;
      }*/
}
