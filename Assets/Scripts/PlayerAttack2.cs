using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack2 : MonoBehaviour
{

    public int damage;
    //public float playerAttackSpeed = 3f;
    private float timeBetweenAttack;
    public float startTimeBetweenAttack = 3f;
  //  public Animator animator;
    public Transform attackPosition;
    public float attackRanage;
    public LayerMask enemies;
   // public float attackRate = 2f;
    //private float nextAttackTime = 0f;


    private void Start()
    {
        //animator.GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if(timeBetweenAttack <= 0)
        //if(Time.time >= nextAttackTime)
        {

            if (Input.GetMouseButtonDown(0))
            {
                //Debug.Log("Attack");
                Attack();
                timeBetweenAttack = startTimeBetweenAttack;
                //nextAttackTime = Time.time + 1f / attackRate;
            }

           //timeBetweenAttack = startTimeBetweenAttack;
        }
        else
        {
            timeBetweenAttack -= Time.deltaTime;
        }

    }

    void Attack()
    {
       //animator.SetTrigger("Attack");
        Collider2D[] enemiesDie = Physics2D.OverlapCircleAll(attackPosition.position, attackRanage, enemies);
        /*for (int i = 0; i < enemiesDie.Length; i++)
        {
            enemiesDie[i].GetComponent<Enemy>().TakeDamage(damage);
        } 
        */
        
        foreach(Collider2D enemy in enemiesDie)
        {
            enemy.GetComponent<Enemy>().TakeDamage(damage);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPosition.position, attackRanage);
    }
}
