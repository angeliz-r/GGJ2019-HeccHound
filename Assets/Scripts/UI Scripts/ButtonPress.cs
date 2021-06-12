using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour {

    private static bool p2 = false;
    public GameObject W, A, S, D, Q, E, R, I, J, K, L, U, O, P;



    // Update is called once per frame
    void Update()
    {
        p2 = spawnPlayer2.p2status;
        if (Input.GetKey(KeyCode.W) && Time.timeScale == 1)
        {
            W.SetActive(true);
        } else
        {
            W.SetActive(false);
        }

        if (Input.GetKey(KeyCode.A) && Time.timeScale == 1)
        {
            A.SetActive(true);
        }
        else
        {
            A.SetActive(false);
        }

        if (Input.GetKey(KeyCode.S) && Time.timeScale == 1)
        {
            S.SetActive(true);
        }
        else
        {
            S.SetActive(false);
        }

        if (Input.GetKey(KeyCode.D) && Time.timeScale == 1)
        {
            D.SetActive(true);
        }
        else
        {
            D.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Q) && Time.timeScale == 1)
        {
            Q.SetActive(true);
        }
        else
        {
            Q.SetActive(false);
        }

        if (Input.GetKey(KeyCode.E) && Time.timeScale == 1)
        {
            E.SetActive(true);
        }
        else
        {
            E.SetActive(false);
        }
        if (Input.GetKey(KeyCode.R) && Time.timeScale == 1)
        {
            R.SetActive(true);
        }
        else
        {
            R.SetActive(false);
        }

        //2P

        if (Input.GetKey(KeyCode.I) && Time.timeScale == 1  && p2)
        {
            I.SetActive(true);
        }
        else
        {
            I.SetActive(false);
        }
        if (Input.GetKey(KeyCode.J) && Time.timeScale == 1 && p2)
        {
            J.SetActive(true);
        }
        else
        {
            J.SetActive(false);
        }
        if (Input.GetKey(KeyCode.K) && Time.timeScale == 1 && p2)
        {
            K.SetActive(true);
        }
        else
        {
            K.SetActive(false);
        }
        if (Input.GetKey(KeyCode.L) && Time.timeScale == 1 && p2)
        {
            L.SetActive(true);
        }
        else
        {
            L.SetActive(false);
        }
        if (Input.GetKey(KeyCode.U) && Time.timeScale == 1 && p2)
        {
            U.SetActive(true);
        }
        else
        {
            U.SetActive(false);
        }
        if (Input.GetKey(KeyCode.O) && Time.timeScale == 1 && p2)
        {
            O.SetActive(true);
        }
        else
        {
            O.SetActive(false);
        }
        if (Input.GetKey(KeyCode.P) && Time.timeScale == 1 && p2)
        {
            P.SetActive(true);
        }
        else
        {
            P.SetActive(false);
        }
    }
}
