using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShoe : MonoBehaviour {

    public GameObject shoe;
    private float min = 12f, spawnTimer;
    private bool spawned;

    void Start()
    {
        spawnThis();
    }

    void Update()
    {
        if (spawned)
        {
            spawnTimer = Time.time + min;
            spawned = false;
        }
        if (Time.time > spawnTimer)
        {
            spawnThis();
        }
    }
    void spawnThis()
    {
        GameObject spawn = Instantiate(shoe, transform.position, Quaternion.identity);
        spawned = true;
    }
}
