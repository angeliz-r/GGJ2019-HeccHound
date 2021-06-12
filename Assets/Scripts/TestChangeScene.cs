using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestChangeScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetMouseButtonDown (0)) {
			SceneTransition.instance.LoadScene ("Title_HeccHound");
		}

	}
}
