using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniformRectilinear : MonoBehaviour {

    Rigidbody2D rb;
    float time = 0.000f;
    float velocity;
    float displacement;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
		if (Input.GetKey(KeyCode.Space))
        {
            rb.position = new Vector2(13f, transform.position.y);
        }
	}
}
