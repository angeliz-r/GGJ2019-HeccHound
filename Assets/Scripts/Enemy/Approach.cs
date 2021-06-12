using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Approach : MonoBehaviour {

    public GameObject sight;
    public Transform target;
    public Rigidbody2D body;
    private float moveSpeed, xMin;

	private bool amDead = false;
	private Animator anim;

    // Use this for initialization
    void Start () {
        target = GameObject.FindGameObjectWithTag("Lola").GetComponent<Transform>();
        moveSpeed = 2f;
        body = GetComponent<Rigidbody2D>();
		anim = GetComponentInChildren<Animator> ();
    }
	
	// Update is called once per frame
	void Update () {
        CalculateScreenPoints();

        Debug.DrawLine(transform.position, sight.transform.position, Color.green);
        RaycastHit2D hit = Physics2D.Linecast(transform.position, sight.transform.position, 1 << LayerMask.NameToLayer("NonPlayer"));

        var direction = target.transform.position - transform.position;
        if (transform.position.x > target.position.x)
        {
            if (hit.collider != null)
            {
                body.velocity = direction;
            }
        }
        else
        {
            body.velocity = new Vector2(2f, direction.y);
        }
    }

    void FixedUpdate()
    {
        movement();
    }
    void movement()
    {

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
        if(collision.tag == "Lola")
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
