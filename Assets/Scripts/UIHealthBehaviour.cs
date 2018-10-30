using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHealthBehaviour : MonoBehaviour
{

    public Image healthbar;
    public HealthScriptable Health;
	
	void Update ()
	{
	    healthbar.fillAmount = (float) Health.health / Health.maxHealth;
	}
}
