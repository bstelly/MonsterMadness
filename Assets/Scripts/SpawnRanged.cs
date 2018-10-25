using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRanged : MonoBehaviour
{
    public GameObject rangedItem;
    public GameEvent onRangePress;

    private bool fired = false;


    void Update()
    {
        OnButtonPressAction();
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
                Debug.Log("Spaaaaaawn");
                onRangePress.Raise();
                
            }
        }
    }

    IEnumerator ResetAttack()
    {
        while (true)
        {
            yield return new WaitForSeconds(2.0f);
            fired = false;
            break;
        }
    }
}
