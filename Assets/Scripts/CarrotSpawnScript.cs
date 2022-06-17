using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotSpawnScript : MonoBehaviour
{
    public GameObject carrot;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 7f;
    float nextSpawn = 0.5f;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-8.38f, 8.58f);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(carrot, whereToSpawn, Quaternion.identity);
        }
    }
}
