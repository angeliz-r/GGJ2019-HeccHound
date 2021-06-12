using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbienceManager : MonoBehaviour {

	public static AmbienceManager instance;
	public AudioClip ambientClip;

	private AudioSource audSource;

	// Use this for initialization
	void Awake () {
		if (instance != null) {
			Destroy (this.gameObject);
		} else {
			instance = this;
			DontDestroyOnLoad (this.gameObject);
		}
	}

	void Start(){
		audSource = GetComponent<AudioSource> ();
	}

	public void playAmbience(){
		audSource.PlayOneShot (ambientClip);
	}

}
