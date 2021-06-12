﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSpriteMask : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		Vector3 tempo = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		tempo.z = 0;

		transform.position = tempo;
	}
}
