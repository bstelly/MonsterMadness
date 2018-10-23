using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBehaviourScript : MonoBehaviour {

    public int damageAmount;

    public int DamageAmount
    {
        get { damageAmount; }
        set { damageAmount = value; }
    }

    public void doDamage(int value)
    {
        int health = 100;
        for(health>0;value>0;health-value)
        {
            health > 0 - value <= 100;
            return health;
        }
    }
}
