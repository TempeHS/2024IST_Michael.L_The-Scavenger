using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public Transform[] patrolPoints;
    public float moveSpeed; 
    public int patrolDestination;
    public Transform playerTransform; 
    public bool isChasing;
    public float chaseDistance; 
    public PlayerHealth playerHealth;

    void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
    }

    void Update()
    {
        if(playerHealth.health <= 0)
        {
            isChasing = false;
        }

        if(isChasing) 
        {
            if(transform.position.x > playerTransform.position.x)
            {
                transform.localScale = new Vector3(1, 1, 1);
                transform.position += Vector3.left * moveSpeed * Time.deltaTime;
            }
            if(transform.position.x < playerTransform.position.x)
            {
                transform.localScale = new Vector3(-1, 1, 1);
                transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            }
        }

        else 
        {

            if(Vector2.Distance(transform.position, playerTransform.position) < chaseDistance)
            {
                isChasing = true; 
            }

            if(patrolDestination == 0)
            {
                transform.position = Vector2.MoveTowards(transform.position, patrolPoints[0].position, moveSpeed * Time.deltaTime);
                if(Vector2.Distance(transform.position, patrolPoints[0].position) < 0.2f)
                {
                    transform.localScale = new Vector3(-1, 1, 1);
                    patrolDestination = 1;
                }
            }



            if(patrolDestination == 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, patrolPoints[1].position, moveSpeed * Time.deltaTime);
                if(Vector2.Distance(transform.position, patrolPoints[1].position) < 0.2f)
                {
                    transform.localScale = new Vector3(1, 1, 1);
                    patrolDestination = 0;
                }
            }



        }
    }
}
