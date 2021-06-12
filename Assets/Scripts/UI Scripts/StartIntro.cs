using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartIntro : MonoBehaviour {
    public void Next()
    {
        SceneTransition.instance.LoadScene("CutScene1");
        Time.timeScale = 1;
    }
}
