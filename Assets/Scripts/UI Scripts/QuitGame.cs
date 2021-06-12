using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour {

    public void Next()
    {
        SceneTransition.instance.LoadScene("QuitScreen");
    }
}
