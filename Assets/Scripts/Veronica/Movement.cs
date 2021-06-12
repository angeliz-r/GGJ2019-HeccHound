using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public Rigidbody2D body;
    private float moveSpeed;
    public bool grounded;

	// Use this for initialization
	void Start () {
        moveSpeed = 1f;
        body = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        detectGround();
    }

    void FixedUpdate()
    {
        if (grounded)
        {
            movement();
        }
    }

    void detectGround()
    {
        Debug.DrawLine(transform.position, new Vector2(transform.position.x, transform.position.y - transform.localScale.y * 5f), Color.green);
        grounded = Physics2D.Linecast(transform.position, new Vector2(transform.position.x, transform.position.y - transform.localScale.y * 5f), 1 << LayerMask.NameToLayer("NonPlayerGround"));
    }

    void movement()
    {
        var moveVector = new Vector2(1f, 0f);
        moveVector.Normalize();
        body.MovePosition(new Vector2((transform.position.x + moveVector.x * moveSpeed * Time.deltaTime),
                transform.position.y + moveVector.y * moveSpeed * Time.deltaTime));
    }
}
