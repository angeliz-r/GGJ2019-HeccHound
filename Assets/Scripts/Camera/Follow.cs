using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

    public Transform lola;
    
	// Use this for initialization
	void Start () {
        lola = GameObject.FindGameObjectWithTag("Lola").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        follow();
	}

    void follow()
    {
        var cameraPosition = new Vector2(lola.position.x, transform.position.y);
        transform.position = cameraPosition;
    }
}
