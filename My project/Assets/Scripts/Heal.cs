using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    public PlayerHealth playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
    }

    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player")
        {
            playerHealth.health = playerHealth.maxHealth;
        }
    }
}
