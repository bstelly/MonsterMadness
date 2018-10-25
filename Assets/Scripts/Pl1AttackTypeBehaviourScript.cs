using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pl1AttackTypeBehaviourScript : Pl2AttackBehaviourScript
{
    GameObject P1;
    public int pl1meleeDamage = 5;
    public int pl1rangedDamage = 3;
    public int pl1specialDamage = 8;
    public int pl1Health;
    public float attackDuration = 0.3F;
    public bool isAttacking;
    public bool isBlocking;
 

    //fireball is b  fire2
    //basic attack is fire 1 button x.
    //y is melee which is fire 3.
    //b is speaicl which is fire4 .
    public int pl1health
    {
        set { pl1Health = value; }
        get { return pl1Health; }
    }
    void start()
    {

    }
    int pl1meleeAttack(int amount)
    {
        for (amount = pl1meleeDamage; pl1Health > 0;)
        {
            pl1Health -= pl1meleeDamage;
            return pl1health;
        }
        return pl1health;
    }
    int pl1rangedAttack(int amount)
    {
        for (amount = pl1rangedDamage; pl1Health > 0;)
        {
            pl1Health -= pl1rangedDamage;
            return pl1health;
        }
        return pl1health;

    }
    int pl1SpecialAttack(int amount)
    {
        for (amount = pl1specialDamage; pl1Health > 0;)
        {
            pl1Health -= pl1specialDamage;
            return pl1health;
        }
        return pl1health;
    }
    void pl1doMeleeAttack(Collider collision)
    {

        for (pl1meleeAttack(5); pl1health > 0;)
        {
            collision.gameObject.CompareTag("Pl2");
        }
        if (Input.GetButton("Fire0") == true)
        {
            pl1meleeAttack(5);
        }

    }
    void pl1doRangedAttack(Collider collision)
    {
        for (pl1rangedAttack(3); pl1health > 0;)
        {
            collision.gameObject.CompareTag("Pl2");

            if (Input.GetButton("Fire2") == true)
            {
                pl1rangedAttack(3);
            }
        }
    }
    void pl2doSpecialAttack(Collider collision)
    {
        for (pl1SpecialAttack(8); pl1health > 0;)
        {
            collision.gameObject.CompareTag("Pl2");

            if (Input.GetButton("Fire") == true)
            {
                pl1SpecialAttack(8);
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
        if (col.tag == "Pl2")
        {
            if (col.tag == "Pl2")
            {
                col.SendMessage("attacking Player2", 1, SendMessageOptions.DontRequireReceiver);
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
        if (Input.GetButtonDown("Fire3") == true)
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