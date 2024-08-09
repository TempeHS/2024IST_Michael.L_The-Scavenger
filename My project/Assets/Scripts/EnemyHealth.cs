using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public int maxHealth = 100;
    int currentHealth;
    public GameObject[] itemDrops;

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
            ItemDrop();
        
        }
    }

    void Die()
    {
        Debug.Log("Enemy felled");

    }

    private void ItemDrop()
    {
        Debug.Log("drop");
        for (int i = 0; i < itemDrops.Length; i++)
        {
            Instantiate(itemDrops[i], transform.position + new Vector3(0, 1, 0), Quaternion.identity);
        }
    }
}
