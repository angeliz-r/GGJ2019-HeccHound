using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene3Audio : MonoBehaviour {
    public void Whine()
    {
        SFXManager.instance.playAudio(3);
    }
    public void Bork()
    {
        SFXManager.instance.playAudio(4);
    }
}
