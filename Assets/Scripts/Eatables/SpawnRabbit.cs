using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRabbit : MonoBehaviour {

    public GameObject rabbit;
    private float min = 10f, max = 25f, spawnTimer;
    private bool spawned;

    void Start()
    {
        spawnThis();
    }

    void Update()
    {
        if (spawned)
        {
            spawnTimer = Time.time + Random.Range(min, max);
            spawned = false;
        }
        if (Time.time > spawnTimer)
        {
            spawnThis();
        }
    }
    void spawnThis()
    {
        GameObject spawn = Instantiate(rabbit, transform.position, Quaternion.identity);
        spawned = true;
    }
}
