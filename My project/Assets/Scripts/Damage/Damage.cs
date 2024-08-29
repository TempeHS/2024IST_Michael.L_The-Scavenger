using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public PlayerHealth pHealth;
    public float damage;
    public PlayerMovement playerMovement;
    private Animator anim;

    void Start()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {

            playerMovement.KBCounter = playerMovement.KBTotalTime;

            if(other.transform.position.x <= transform.position.x)
            {
                playerMovement.KnockFromRight = true;
            }
            if(other.transform.position.x > transform.position.x)
            {
                playerMovement.KnockFromRight = false;
            }

            pHealth.health -= damage;

        }
    }


}
