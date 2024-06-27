using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public int maxHealth = 100;
    int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("u hit me");


        if(currentHealth <= 0)
        {
            Die();
            gameObject.SetActive(false);
        }
    }

    void Die()
    {
        Debug.Log("Enemy felled");

    }
}
