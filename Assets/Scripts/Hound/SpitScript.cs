using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpitScript : MonoBehaviour {

    float xMin, xMax;
    private void Update()
    {
        CalculateScreenPoints();
        if (transform.position.x > xMax || transform.position.x < xMin)
            Destroy(this.gameObject);
    }

    void CalculateScreenPoints()
    {
        Vector3 lowerLeftCorner = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
        Vector3 upperRightCorner = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0));
        xMin = lowerLeftCorner.x;
        xMax = upperRightCorner.x;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
    }
}
