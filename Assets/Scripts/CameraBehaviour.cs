using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    //public GameObject cameraPositionObject;
    public GameObject playerOne;
    public GameObject playerTwo;

    void Update () {
	    var midpoint = new Vector3((playerOne.transform.position.x + playerTwo.transform.position.x) / 2,
	        (playerOne.transform.position.y + playerTwo.transform.position.y) / 2);
	    transform.position = new Vector3(midpoint.x, midpoint.y, transform.position.z);

    }
}
