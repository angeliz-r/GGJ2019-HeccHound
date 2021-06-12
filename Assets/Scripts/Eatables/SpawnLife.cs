using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLife : MonoBehaviour {

    public GameObject life;
    private float min = 60f, max = 100f, spawnTimer;
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
        GameObject spawn = Instantiate(life, transform.position, Quaternion.identity);
        spawned = true;
    }
}
