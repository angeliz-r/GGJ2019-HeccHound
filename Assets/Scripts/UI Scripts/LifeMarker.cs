using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeMarker : MonoBehaviour {

	public static LifeMarker instance;
	public GameObject[] lifeSlots;
	public GameObject angel;

	private int index;
	private int prevLife = 0;

	// Use this for initialization
	void Awake () {
		if (instance == null)
			instance = this;

		createLives ();
		//prevLife = index;
	}

	void Update(){
		createLives ();
	}

	void createLives(){
		if (prevLife < index) {
			for (; prevLife < index; prevLife++) {
				GameObject temp = Instantiate (angel, lifeSlots [prevLife].transform.localPosition, Quaternion.identity);
				temp.transform.parent = this.transform;
			}
		} else {
			prevLife = index;
		}

	}

	public void setLife(int lives){
		index = lives;
	}

	public int getLife(){
		return index;
	}

}
