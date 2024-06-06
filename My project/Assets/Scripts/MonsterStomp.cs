using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterStomp : MonoBehaviour
{
    private void onCollisionEnter2D(Collision2D Collision)
    {
        if(Collision.gameObject.tag == "Weak Point")
        {
            Destroy(Collision.gameObject);
        }
    }
}
