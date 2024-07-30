using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public Image HealthBarColour;
    public GameObject player;
    public Transform respawnPoint;
    public Animator anim;
    public PlayerMovement playerMovement;
    

    void Start()
    {
        maxHealth = 200;
        maxHealth = health;
        

        playerMovement = FindObjectOfType<PlayerMovement>();
    }

    
    void Update()
    {
        HealthBarColour.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);
        
        if(health <=0) 
        {
            die();
        }
    }

    private void die()
    {
        anim.SetBool("IsDead", true);
        playerMovement.speed = 0;
        playerMovement.jumpingPower = 0;
        StartCoroutine(Dying());
        this.enabled = false;
        GetComponent<BoxCollider2D>().enabled = true;
    }

    IEnumerator Dying()
    {
        yield return new WaitForSeconds(3);
        player.transform.position = respawnPoint.position;
        playerMovement.speed = 0.8f;
        playerMovement.jumpingPower = 2f;
        anim.SetBool("IsDead", false);
        health = maxHealth;
        GetComponent<PlayerHealth>().enabled = true;
    }
}
