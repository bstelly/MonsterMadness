using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRanged : MonoBehaviour
{
    public Object FireBall;
    public Object Boulder;

    public GameObject player1;
    public GameObject player2;

    public GameEvent onRangePress;


    void OnPressFire()
    {
        if (Input.GetButton("Fire1"))
        {
            Debug.Log("Supa Hot Fiya");
            onRangePress.Raise();
        }
    }

    public void SpawnItem()
    {
        
    }
}
