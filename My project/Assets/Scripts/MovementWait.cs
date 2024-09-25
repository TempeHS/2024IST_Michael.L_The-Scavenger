using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementWait : MonoBehaviour
{

    public PlayerMovement playerMovement;


    void Start()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
        StartCoroutine(MoveWait());
    }

    IEnumerator MoveWait()
    {
        playerMovement.enabled = false;
        yield return new WaitForSeconds(3);
        playerMovement.enabled = true;
    }

}

