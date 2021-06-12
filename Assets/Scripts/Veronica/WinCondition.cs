using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinCondition : MonoBehaviour {

    public float winTime, winTimer, currentTime;
    private bool won;
    public Slider progressBar;

	// Use this for initialization
	void Start () {
        winTime = 180f;
        progressBar = GetComponent<Slider>();
        won = false;
        winTimer = Time.time + winTime;
	}
	
	// Update is called once per frame
	void Update () {
        currentTime = Time.time;
		if(Time.time > winTimer && !won)
        {
            win();
            won = true;
        }
        progressBar.value = currentTime / winTime * 100f;
	}

    public void win()
    {
        SceneTransition.instance.LoadScene("CutScene3");
    }
}
