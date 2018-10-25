using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed;
    private Rigidbody rb2d;
    private float jumpForce = 2f;
    private bool isGrounded = true;
    private Rigidbody pRigidBody;

	// Use this for initialization
	void Start ()
    {
        rb2d = GetComponent<Rigidbody>();
        pRigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Jump");
        Vector2 movement = new Vector2(moveHorizontal, 0);
        //Vector2 movemental = new Vector2(0, moveVertical);
        rb2d.AddForce(movement * speed);
        if (Input.GetButton("Jump"))
        {
            if (isGrounded == true)
            {
                Debug.Log("Button Pressed");
                transform.position += Vector3.up * 50f * Time.deltaTime;
            }
            else { Debug.Log("Don't press me >:("); }
        }
        if (Input.GetButton("Fire1"))
        {
            //Debug.Log("Supa Hot Fiya P1");
        }
        if (Input.GetButton("Fire2"))
        {
            Debug.Log("Basic Attack P1");
        }
        if (Input.GetButton("Fire3"))
        {
            Debug.Log("Meelee P1");
        }
    }

    void OnCollisionEnter(Collision theCollision)
    {
        if(theCollision.gameObject.CompareTag("Plane"))
        {
            Debug.Log("Entered");
            isGrounded = true;
            pRigidBody.AddForce(new Vector3(0, jumpForce, 0));
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.CompareTag("Plane"))
        {
            Debug.Log("Exited");
            isGrounded = false;
        }
    }
}

