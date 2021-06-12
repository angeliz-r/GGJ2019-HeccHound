using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {
    public GameObject Menu;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                Menu.SetActive(true);
                Time.timeScale = 0;

            }
            else
            {
                Menu.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }
}
