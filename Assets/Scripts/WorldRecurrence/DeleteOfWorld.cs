using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOfWorld : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "Deleter") {
			Destroy (other.transform.parent.gameObject);
		}
	}
}
