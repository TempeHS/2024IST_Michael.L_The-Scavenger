using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public int maxHealth = 100;
    int currentHealth;
    public GameObject[] itemDrops;
    public Animator anim;
    public EnemyMovement enemyMovement;
    public Damage damage;
    public PlayerMovement playerMovement;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        enemyMovement = FindObjectOfType<EnemyMovement>();
        damage = FindObjectOfType<Damage>();
        playerMovement = FindObjectOfType<PlayerMovement>();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("u hit me");


        if(currentHealth <= 0)
        {
            Die();        
        }
    }

    void Die()
    {
        Debug.Log("Enemy felled");
        Debug.Log("drop");
        for (int i = 0; i < itemDrops.Length; i++)
        {
            Instantiate(itemDrops[i], transform.position + new Vector3(0, 1, 0), Quaternion.identity);
        }

        anim.SetBool("IsDead", true);
        enemyMovement.enabled = false;
        damage.enabled = false;
        damage.damage = 0;
        playerMovement.KBForce = 0;
        playerMovement.KBCounter = 0;
        this.enabled = false;

    
    }
}
    
