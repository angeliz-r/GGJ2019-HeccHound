using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour {

	public GameObject fadePanel;
	public Animator fadeAnim;

	public static SceneTransition instance;

	void Start () {
		//Singleton

		if(instance != null){
			Destroy(this.gameObject);
		}else{
			instance = this;
			DontDestroyOnLoad(this.gameObject);
		}

	}
	
	public void LoadScene(string sceneName){
		StartCoroutine (FadeInOut (sceneName));
	}

	IEnumerator FadeInOut(string sceneName){
	
		fadePanel.SetActive (true); //Activate the Panel
		fadeAnim.Play ("FadeIn"); //Play the animation FadeIn
		yield return StartCoroutine (MyCoroutine.WaitForRealSeconds (1.5f)); //use the selfMade class MyCoroutine return null

		SceneManager.LoadScene (sceneName); //Load the newScene

		fadeAnim.Play ("FadeOut"); //Play animation FadeOut, the black will now fade.
		yield return StartCoroutine (MyCoroutine.WaitForRealSeconds (0.7f)); 
		fadePanel.SetActive (false); //Deactivate the Panel

	}

		




}
