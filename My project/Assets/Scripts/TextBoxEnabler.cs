using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TextBoxEnabler : MonoBehaviour
{

    public GameObject TextBox; // Assign your panel in the Inspector

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Assuming the player has the tag "Player"
        {  
            Debug.Log("skirt");
            Image image = TextBox.GetComponent<Image>();
            if (image != null)
            {
                image.enabled = true; // Disable the Image component
                Debug.Log("dfo");
            }

            TextMeshProUGUI textMeshPro = TextBox.GetComponentInChildren<TextMeshProUGUI>();
            if (textMeshPro != null)
            {
                textMeshPro.enabled = true;
            }
        }
    }
}
