using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSquirrel : MonoBehaviour
{
    public GameObject squirrel;

    void Start()
    {
        spawnThis();
    }

    void spawnThis()
    {
        GameObject spawn = Instantiate(squirrel, transform.position, Quaternion.identity);
        spawn.transform.parent = this.transform.parent;
        Destroy(this.gameObject);
    }
}
