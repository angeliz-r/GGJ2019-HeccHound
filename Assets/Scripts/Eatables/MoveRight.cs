using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{

    public Rigidbody2D body;
    private float moveSpeed, xMin;

    void Start()
    {
        moveSpeed = 2f;
        body = GetComponent<Rigidbody2D>();
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
        var moveVector = new Vector2(1f, 0f);
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

}
