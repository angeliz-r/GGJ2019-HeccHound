using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantSpawner : MonoBehaviour {
	public static PlantSpawner instance;

	private GameObject plants = null;

	// Use this for initialization
	void Start () {
		if (instance == null)
			instance = this;
	}

	void Update(){
		plantSomething ();
	}
	
	void plantSomething(){
		if (plants != null) {
			
			Debug.Log ("MAY LAMAN");
			plants = null;
		}
	}

	public void setPlants(GameObject item){
		plants = item;
		Vector3 temp = transform.position;

		if (plants.name == "Tree") {
			temp.y += 1f;
		}
		else
			temp.y += 0.6f;
		
		Instantiate (plants, temp, Quaternion.identity);
		//Debug.Log ("PASOK!!!");
	}

}
