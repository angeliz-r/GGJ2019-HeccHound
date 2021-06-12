using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPlayer2 : MonoBehaviour {

    public GameObject player2, singleplayer, playerTwoUi;
    public static bool p2status = false;

	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.K))
        {
            p2status = true;
            GameObject hound = Instantiate(player2, transform.position, Quaternion.identity);
            hound.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -5f), ForceMode2D.Impulse);
            singleplayer.SetActive(false);
            playerTwoUi.SetActive(true);
            Destroy(this.gameObject);
        }
	}
}
