using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBoxEnabler : MonoBehaviour
{

    public TextBox textBox;

    void Start()
    {
        textBox = FindObjectOfType<TextBox>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("sajndkjn");
            textBox.enabled = true;
        }
    }
}
