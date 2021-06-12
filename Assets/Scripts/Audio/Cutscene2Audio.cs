using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene2Audio : MonoBehaviour {
    public void BadBork()
    {
        SFXManager.instance.playAudio(0);
    }
    public void Bork()
    {
        SFXManager.instance.playAudio(4);
    }
}
