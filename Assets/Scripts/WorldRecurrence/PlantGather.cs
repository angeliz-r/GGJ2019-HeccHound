                                                                                                                                                                                                                                                                                                                                                                                                                                                      using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantGather : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Plants") {
			PlantSpawner.instance.setPlants (other.gameObject);
			Destroy (other.gameObject);
		}
	}

}