 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{

    public Animator animator;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public int attackDamage = 40;
    [SerializeField] private Cooldown cooldown;
    private EnemyHealth enemyHealth;
    private PlayerCombat playerCombat;


  // Update is called once per frame

    void Start()
    {
        enemyHealth = FindObjectOfType<EnemyHealth>();
    }

    void Update()
    {
        if (cooldown.IsCoolingDown) return;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();

            cooldown.StartCooldown();
        }
    }

    void Attack()
    {


        animator.SetTrigger("Attack");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers); 

        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<EnemyHealth>().TakeDamage(attackDamage);
        }

        if(enemyHealth.currentHealth <= 0)
        {
            StartCoroutine(AttackWait());
        }

    }
    

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }


    IEnumerator AttackWait()
    {
        this.enabled = false;
        yield return new WaitForSeconds(3);
        Debug.Log("combat wait");
        this.enabled = true;
    }
}
