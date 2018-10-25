using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public GameEvent onAnyButtonPress;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            onAnyButtonPress.Raise();
        }
    }

    public void JumpPressed()
    {
        Debug.Log("pressed");
        transform.position += Vector3.up;
    }
}

   
    