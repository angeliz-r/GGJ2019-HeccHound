using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToStart : MonoBehaviour {
    void Update()
    {
        if (Input.GetKey(KeyCode.K))
            SceneTransition.instance.LoadScene("HeccHound");

    }
    public void Next()
    {
        SceneTransition.instance.LoadScene("HeccHound");
    }
}
