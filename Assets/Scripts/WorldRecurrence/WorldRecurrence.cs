using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldRecurrence : MonoBehaviour {

	public GameObject world;
	public GameObject spawnPoint;

	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "Deleter") {
			Instantiate (world, spawnPoint.transform.position, Quaternion.identity);
		}
	}
}
