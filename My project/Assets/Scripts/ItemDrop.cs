using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrop : MonoBehaviour
{
    private Rigidbody2D itemRB;
    public float dropForce = 5;
    private GameObject MeatItemDrop;

    // Start is called before the first frame update
    void Start()
    {
        itemRB = GetComponent<Rigidbody2D>();
        itemRB.AddForce(Vector2.up * dropForce, ForceMode2D.Impulse);
    }

private void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.tag == "Player")
    {
        Destroy(gameObject);
    }        
}
}
