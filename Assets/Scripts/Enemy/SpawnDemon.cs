using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDemon : MonoBehaviour {

    public GameObject demon;

    void Start()
    {
        GameObject spawn = Instantiate(demon, transform.position, Quaternion.identity);
        spawn.transform.parent = this.transform.parent;
        Destroy(this.gameObject);
    }
}
