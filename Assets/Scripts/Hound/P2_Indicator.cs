using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2_Indicator : MonoBehaviour {

    public GameObject hound;
    public Sprite sprite;

    // Use this for initialization
    void Start()
    {
        hound = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > hound.transform.position.y)
        {
            sprite = Resources.Load<Sprite>("2P_overhead");
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (transform.position.y < hound.transform.position.y)
        {
            sprite = Resources.Load<Sprite>("2P_overhead_reverse_w");
            transform.rotation = Quaternion.Euler(180f, 0, 0);
        }
        this.GetComponent<SpriteRenderer>().sprite = sprite;
    }
}
