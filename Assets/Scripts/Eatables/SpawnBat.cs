using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBat : MonoBehaviour {

    public GameObject bat;
    private float min = 12f, max = 55f, spawnTimer;
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
        if(Time.time > spawnTimer)
        {
            spawnThis();
        }
    }

    void spawnThis()
    {
        GameObject spawn = Instantiate(bat, transform.position, Quaternion.identity);
        spawned = true;
    }
}
