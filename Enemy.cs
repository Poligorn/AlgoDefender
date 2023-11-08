using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public float speed = 1f;
    float borderPosX;
    public Animator animator;
    public float shootInterval = 1f;
    public float shootTimer = 0f;

    private void Start()
    {
        borderPosX = Corn.singleton.transform.position.x;
    }

    private void Update()
    {
        if (shootTimer > 0)
        {
            shootTimer -= Time.deltaTime;
        }

        float enemyPosX = transform.position.x;

        if (enemyPosX > borderPosX)
        {
            animator.SetBool("isMoving", true);
            transform.position += -transform.right * speed * Time.deltaTime;

        }
        else
        {
            animator.SetBool("isMoving", false);

            if (shootTimer <= 0)
            {
                Attack();
                shootTimer = shootInterval;
            }
        }
    }

    public void TakeDamage()
    {
        health -= 1;

        if (health <= 0)
            Destroy(gameObject);
    }

    public void Attack()
    {
        Corn.singleton.TakeDamage();
    }

}
