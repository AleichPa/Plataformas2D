using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private bool attacking = false;
    private float attackTimer = 0;
    private float attackCd = 0.3f;

    public Collider2D attackTrigger;

    private Animator anim;

    private void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
        attackTrigger.enabled = false;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !attacking)
        {
            anim.SetTrigger("Attack");
            attacking = true;
            attackTimer = attackCd;
            attackTrigger.enabled = true;
        }

        if (attacking)
        {
            if (attackTimer > 0) 
            {  
                attackTimer -= Time.deltaTime;
            }
            else
            {
                attacking = false;
                attackTrigger.enabled = false;
            }
        }
        //anim.SetBool("Attacking", attacking);
        
    }
}
