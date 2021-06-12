using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour {

    public Rigidbody2D body;
	public float directional;

    private float moveSpeed, xMin;

	private bool amDead = false;
	private Animator anim;

    void Start()
    {
        moveSpeed = 1f;
        body = GetComponent<Rigidbody2D>();
		anim = GetComponentInChildren<Animator> ();
    }

    private void Update()
    {
        //CalculateScreenPoints();
    }

    void FixedUpdate()
    {
        movement();
    }
    void movement()
    {
		var moveVector = new Vector2(directional, 0f);
        moveVector.Normalize();
        body.MovePosition(new Vector2((transform.position.x + moveVector.x * moveSpeed * Time.deltaTime),
                transform.position.y + moveVector.y * moveSpeed * Time.deltaTime));
    }
    void CalculateScreenPoints()
    {
        Vector3 lowerLeftCorner = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
        xMin = lowerLeftCorner.x;
        if (transform.position.x + transform.localScale.x * 2f < xMin)
            Destroy(this.gameObject);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Lola")
        {
           // Destroy(this.gameObject);
			amDead = true;
			anim.SetBool ("isDead", amDead);
        }
        if (collision.tag == "DeleteEdible")
            Destroy(this.gameObject);
    }

	public void DestroyThis(){
		Destroy(this.gameObject);
	}

}
