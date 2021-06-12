using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene1Audio : MonoBehaviour {

    private void Start()
    {
        AmbienceManager.instance.playAmbience();
    }

    public void Bork()
    {
        SFXManager.instance.playAudio(4);
    }
}
