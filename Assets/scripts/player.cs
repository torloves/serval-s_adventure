using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    private Rigidbody2D rigidbody2D;
    float x,y;

    // Use this for initialization
    void Start () {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            x -= 0.3f;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            x += 0.3f;
        }
        if (x >= 20f)
        {
            x = 20f;
        } else if (x <= -20f){
            x = -20f;
        }
        rigidbody2D.velocity = new Vector2(x,y);
        if (x > 0f)
        {
            x -= 0.1f;
        }else if (x < 0f)
        {
            x += 0.1f;
        }
        y -= 0.3f;
    }

    void OnCollisionStay2D()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            x -= 0.2f;
            y = 0f;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            x += 0.2f;
            y = 0f;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            y = 0f;
            y += 10f;
        }

    }
}
