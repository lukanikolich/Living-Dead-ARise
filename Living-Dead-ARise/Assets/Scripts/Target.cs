using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Animator animator;
    private bool isDead = false;

    private float health;

    private void Start()
    {
        animator = GetComponent<Animator>();
        health = Random.Range(30, 70);
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f && !isDead)
        {
            Die();
            isDead = true;
        }
    }

    void Die()
    {
        if (Random.value >= 0.5)
        {
            animator.SetBool("death01", true);
        }
        else
        {
            animator.SetBool("death02", true);
        }
        Score.score++;
    }
}
