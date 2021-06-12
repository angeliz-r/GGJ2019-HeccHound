using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeAngel : Edible {

	private float moveSpeed = 4.0f;
	private float frequency = 3f; //sine speed
	private float magnitude  = 4f; //sine size movemenet

	private Vector3 axis;
	private Vector3 pos;

	public override void edibleAction(){
		int temp = LifeMarker.instance.getLife ();
		LifeMarker.instance.setLife (temp + 1);
		Destroy (this.gameObject);
	}
		

		void Start () {
			pos = transform.position;
			axis = transform.up;
		}

		void Update () {	
			move ();
		}

		void move() {
			pos += transform.right * Time.deltaTime * moveSpeed;
			transform.position = pos + axis * Mathf.Sin (Time.time * frequency) * magnitude;
		}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "DeleteEdible")
            Destroy(this.gameObject);
    }
}
