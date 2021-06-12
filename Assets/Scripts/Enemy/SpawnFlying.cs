using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFlying : MonoBehaviour {

    public GameObject flyingDemon;

    void Start()
    {
        GameObject spawn = Instantiate(flyingDemon, transform.position, Quaternion.identity);
        spawn.transform.parent = this.transform.parent;
        Destroy(this.gameObject);
    }
}
