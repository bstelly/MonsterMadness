using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRanged : MonoBehaviour
{
    public GameObject rangedItem;
    public GameEvent onRangePress;

    protected bool fired = false;


    void Update()
    {
        if(Input.GetButton("Fire1") && !IsInvoking("OnButtonPressAction"))
        {
            fired = false;
            Invoke("OnButtonPressAction", 0);
            fired = true;
        }
    }

    public void SpawnItem()
    {

        Instantiate(rangedItem, transform.position, Quaternion.identity);
    }

    public void OnButtonPressAction()
    {        
        if (Input.GetButton("Fire1"))
        {
            if (fired == false)
            {
                StartCoroutine(ResetAttack());
                fired = true;
                onRangePress.Raise();
            }
        }
    }

    IEnumerator ResetAttack()
    {
        while (true)
        {
            Debug.Log("am doin a shoot");
            fired = false;
            yield return new WaitForSeconds(1.0f);
            break;
        }
    }

    public void CheckFunction()
    {
        
    }
}
