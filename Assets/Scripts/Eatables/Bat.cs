using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : Edible {

	public Player_Controller player;

	private float moveSpeed = 4.0f;
	private float frequency = 12f; //sine speed
	private float magnitude  = 0.15f; //sine size movemenet

	private Vector3 axis;
	private Vector3 pos;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Controller>();
    }

    public override void edibleAction(){

        player.setIsBat(4);
		Destroy (this.gameObject);
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "DeleteEdible")
            Destroy(this.gameObject);
    }



	void Start () {
		pos = transform.position;
		axis = transform.up;
	}

	void Update () {	
		move ();
	}

	void move() {
		pos -= transform.right * Time.deltaTime * moveSpeed;
		transform.position = pos + axis * Mathf.Sin (Time.time * frequency) * magnitude;
	}

}
