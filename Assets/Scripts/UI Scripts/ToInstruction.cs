using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToInstruction : MonoBehaviour {
    void Update()
    {
        if (Input.GetKey(KeyCode.K))
            SceneTransition.instance.LoadScene("Instruction");

    }
    public void Next()
    {
        SceneTransition.instance.LoadScene("Instruction");
    }
}
