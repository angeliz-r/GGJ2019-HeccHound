using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour {

	/*
	 * This script enters into Lola
	 * if player eats an angel, addLives is called
	 */ 

	private int lives = 5;
	//private int maxLives = 7;

	void Start(){
		LifeMarker.instance.setLife (lives);
	}

	void Update(){
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Enemy") {
			lives--;
			//LifeMarker.instance.setLife (lives);
            if(lives <= 0)
			SceneTransition.instance.LoadScene("LoseScreen");
		}
	}

	void checkLives(){
		lives = LifeMarker.instance.getLife ();
	}

}
