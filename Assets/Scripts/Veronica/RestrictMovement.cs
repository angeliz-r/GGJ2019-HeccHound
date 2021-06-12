using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestrictMovement : MonoBehaviour {

	float xMin, xMax, yMin, yMax;

	void Update(){
		CalculateScreenPoints ();
		preventMovement ();
	}

	void CalculateScreenPoints(){

		Vector3 lowerLeftCorner = Camera.main.ViewportToWorldPoint(new Vector3(0,0,0));
		Vector3 upperRightCorner = Camera.main.ViewportToWorldPoint(new Vector3(1,1,0));

		xMin = lowerLeftCorner.x;
		xMax = upperRightCorner.x;
        yMin = lowerLeftCorner.y;
        yMax = upperRightCorner.y;

	}

	void preventMovement(){
		float xPos = Mathf.Clamp(transform.position.x , xMin + 0.5f , xMax - 0.5f);
		float yPos = Mathf.Clamp(transform.position.y ,  yMin + 0.5f , yMax - 0.5f);
		transform.position = new Vector3(xPos, yPos, 0);
	}
}
