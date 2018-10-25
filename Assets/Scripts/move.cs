using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public HealthScriptable health;

	// Use this for initialization
	void Start ()
	{
	    health.health = 100;
	    health.maxHealth = 100;
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.A))
	    {
	        transform.position += new Vector3(-0.1f, 0);
	    }
	    if (Input.GetKey(KeyCode.D))
	    {
	        transform.position += new Vector3(0.1f, 0);
	    }

	    if (Input.GetKey(KeyCode.Space))
	    {
	        health.health -= 2;
	    }

    }
}
