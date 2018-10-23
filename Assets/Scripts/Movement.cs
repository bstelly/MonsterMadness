using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed;
    private Rigidbody rb2d;
    private bool isGrounded = true;

	// Use this for initialization
	void Start ()
    {
        rb2d = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Jump");
        Vector2 movement = new Vector2(moveHorizontal, 0);
        Vector2 movemental = new Vector2(0, moveVertical);
        rb2d.AddForce(movement * speed);

        if (Input.GetButton("Jump"))
            transform.position += Vector3.up * .25f;

        if (isGrounded == true)
        {
            transform.position += Vector3.up * .25f;
        }
    }

    void OnCollisionEnter(Collision theCollision)
    {
        if(theCollision.gameObject.name == "Plane")
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision theCollision)
    {
        if(theCollision.gameObject.name == "Plane")
        {
            isGrounded = false;
        }
    }
}

