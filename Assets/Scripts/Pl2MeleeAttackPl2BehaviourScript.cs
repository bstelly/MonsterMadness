using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pl2AttackBehaviourScript : MonoBehaviour
{
    GameObject Pl2;
    public int pl2meleeDamage = 5;
    public int pl2rangedDamage = 3;
    public int pl2specialDamage = 8;
    public int pl2Health;
    public float attackDuration = 0.3F;
    public bool isAttacking;
    public bool isBlocking;
   
 
        //fireball is b  fire2
        //basic attack is fire 1 button x.
        //y is melee which is fire 3.
        //b is speaicl which is fire4 .
    public int pl2health
    {
        set { pl2Health = value; }
        get { return pl2Health; }
    }
     void start()
    {
      
    }
    int pl2meleeAttack(int amount)
    {
        for (amount = pl2meleeDamage; pl2Health > 0;)
        {
            pl2Health -= pl2meleeDamage;
            return pl2health;
        }
        return pl2health;
    }
    int pl2rangedAttack(int amount)
    {
        for (amount = pl2rangedDamage; pl2Health > 0;)
        {
            pl2Health -= pl2rangedDamage;
            return pl2health;
        }
        return pl2health;

    }
    int pl2SpecialAttack(int amount)
    {
        for (amount = pl2specialDamage; pl2Health > 0;)
        {
            pl2Health -= pl2specialDamage;
            return pl2health;
        }
        return pl2health;
    }
    void pl2doMeleeAttack(Collider collision)
    {
        
        for (pl2meleeAttack(5); pl2health > 0;)
        {
            collision.gameObject.CompareTag("Pl1");
        }
        if (Input.GetButton("Fire0") == true)
        {
            pl2meleeAttack(5);
        }

    }
    void pl2doRangedAttack(Collider collision)
    {
        for(pl2rangedAttack(3);pl2health>0;)
        {
            collision.gameObject.CompareTag("Pl1");

            if (Input.GetButton("Fire2") == true)
            {
                pl2rangedAttack(3);
            }
        }
    }
    void pl2doSpecialAttack(Collider collision)
    {
        for (pl2SpecialAttack(8); pl2health > 0;)
        {
            collision.gameObject.CompareTag("Pl1");

            if (Input.GetButton("Fire") == true)
            {
                pl2SpecialAttack(8);
            }
        }
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire4"))
        {
            isAttacking = true;
        }
        EnableDamage();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Pl1")
        {
            if (col.tag == "Pl1")
            {
                col.SendMessage("attacking Player1", 1, SendMessageOptions.DontRequireReceiver);
            }
        }
    }

    void EnableDamage()
    {
        if (isAttacking == true) return;
        isAttacking = true;
    }
    void enableBlocking()
    {
        if(Input .GetButtonDown("Fire3")==true)
        {
            isBlocking = true;
        }
    }
    IEnumerator DisableDamage()
    {
        yield return new WaitForSeconds(attackDuration);
        isAttacking = false;
    }

}

