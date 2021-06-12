using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToCutscene2 : MonoBehaviour {
    void Update()
    {
        if (Input.GetKey(KeyCode.K))
            SceneTransition.instance.LoadScene("CutScene2");
        
    }
    public void Next()
    {
        SceneTransition.instance.LoadScene("CutScene2");
    }
}
