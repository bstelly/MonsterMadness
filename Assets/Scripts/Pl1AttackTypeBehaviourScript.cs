using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pl1AttackTypeBehaviourScript : MonoBehaviour
{
    GameObject P1;
    public GameObject P2;
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

    void pl1doMeleeAttack()
    {
            pl1meleeAttack(5);
            Debug.Log("Melee");
    }

    void pl1doRangedAttack()
    {
        pl1rangedAttack(3);
        Debug.Log("Wrekt");
    }

    void pl1doSpecialAttack()
    {
            pl1SpecialAttack(8);
            Debug.Log("Special");   
    }

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            pl1doRangedAttack();
            isAttacking = true;
        }
        if (Input.GetButton("Fire4"))
        {
            enableBlocking();
            isAttacking = true;
        }
        if (Input.GetButton("Fire2"))
        {
            pl1doMeleeAttack();
            isAttacking = true;
        }
        if (Input.GetButton("Fire3"))
        {
            pl1doSpecialAttack();
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
        if (Input.GetButtonDown("Fire4") == true)
        {
            isBlocking = true;
        }Debug.Log("IsBlocking");
    }
    IEnumerator DisableDamage()
    {
        yield return new WaitForSeconds(attackDuration);
        isAttacking = false;
    }
}