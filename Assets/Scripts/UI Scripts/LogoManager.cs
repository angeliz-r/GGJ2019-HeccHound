using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoManager : MonoBehaviour {
    public void Next ()
    {
        SceneTransition.instance.LoadScene("Title_HeccHound");
    }
}
