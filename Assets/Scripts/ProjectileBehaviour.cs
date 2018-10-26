using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour {

    public GameObject startPos;

	// Use this for initialization
	void Start () {
        //transform.position = startPos.transform.position;	
	}
	
	// Update is called once per frame
	void Update () {
       
        transform.position += Vector3.left;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
