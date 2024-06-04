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
    
    void Start()
    {
        maxHealth = health;
    }

    
    void Update()
    {
        HealthBarColour.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);

        if(health <=0) 
        {
            player.transform.position = respawnPoint.position;
        }

        if(player.transform.position == respawnPoint.position) 
        {
            health = maxHealth;
        }

    }
}
