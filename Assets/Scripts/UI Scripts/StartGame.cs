using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {
    public void Next()
    {
        SceneTransition.instance.LoadScene("HeccHound");
        Time.timeScale = 1;
    }
}
