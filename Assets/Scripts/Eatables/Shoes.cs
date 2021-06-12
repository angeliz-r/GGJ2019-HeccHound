﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoes : Edible {

	public Player_Controller player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Controller>();
    }


    public override void edibleAction(){

		player.setIsShoe (1);

		Destroy (this.gameObject);
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "DeleteEdible")
            Destroy(this.gameObject);
    }

}
