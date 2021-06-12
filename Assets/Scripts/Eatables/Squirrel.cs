using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squirrel : Edible {

	public Player_Controller player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Controller>();
    }

    public override void edibleAction(){

		player.setIsSquirrel (3);

		Destroy (this.gameObject);
	}
}
