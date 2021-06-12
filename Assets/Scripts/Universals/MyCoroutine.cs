﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MyCoroutine {

	public static IEnumerator WaitForRealSeconds(float time){

		float start = Time.realtimeSinceStartup;

		while (Time.realtimeSinceStartup < (start + time)) {
			yield return null;
		}

	}

}