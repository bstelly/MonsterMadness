using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller2 : MonoBehaviour {

    public float speed;
    private Rigidbody rb2d;
    private float jumpForce = 2f;
    private bool isGrounded = true;
    private Rigidbody pRigidBody;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody>();
        pRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal2");
        float moveVertical = Input.GetAxis("Jump2");
        Vector2 movement = new Vector2(moveHorizontal, 0);
        //Vector2 movemental = new Vector2(0, moveVertical);
        rb2d.AddForce(movement * speed);
        if (Input.GetButton("Jump2"))
        {
            if (isGrounded == true)
            {
                Debug.Log("Button Pressed");
                transform.position += Vector3.up * 100f * Time.deltaTime;
            }
            else { Debug.Log("Don't press me >:("); }

        }
        if (Input.GetButton("Fire1.2"))
        {
            Debug.Log("Supa Hot Fiya P2");
        }
        if (Input.GetButton("Fire2.2"))
        {
            Debug.Log("Basic Attack P2");
        }
        if(Input.GetButton("Fire3.2"))
        {
            Debug.Log("Meelee P2");
        }
    }

    void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.gameObject.CompareTag("Plane"))
        {
            Debug.Log("Entered");
            isGrounded = true;
            pRigidBody.AddForce(new Vector3(0, jumpForce, 0));
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Plane"))
        {
            Debug.Log("Exited");
            isGrounded = false;
        }
    }
}
