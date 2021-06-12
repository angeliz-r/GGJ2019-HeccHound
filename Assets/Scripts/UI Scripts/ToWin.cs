using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToWin : MonoBehaviour {

    void Update()
    {
        if (Input.GetKey(KeyCode.K))
            SceneTransition.instance.LoadScene("WinScreen");

    }
    public void Next()
    {
        SceneTransition.instance.LoadScene("WinScreen");
    }
}
