using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {
    public void Next()
    {
        SceneTransition.instance.LoadScene("Title_HeccHound");
        Time.timeScale = 1;
    }
}
