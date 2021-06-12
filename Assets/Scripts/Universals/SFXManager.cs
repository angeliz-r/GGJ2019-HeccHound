using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour {

	public static SFXManager instance;
	public AudioClip[] sfxClip;

	private AudioSource audSource;

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

	public void playAudio(int index){
		audSource.PlayOneShot (sfxClip [index]);
	}

}
