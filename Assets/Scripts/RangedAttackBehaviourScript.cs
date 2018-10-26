using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedAttackBehaviourScript : MonoBehaviour
{

    public int damage = 3;

    public int Health;
    public int health
    {
        set { Health = value; }
        get { return Health; }
    }

    int Attack(int amount)
    {
        for (amount = damage; Health > 0;)
        {
            Health -= damage;
            return health;
        }
        return health;
    }
}
