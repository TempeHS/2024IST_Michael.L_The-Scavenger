using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutsceneStopper : MonoBehaviour
{   
    public GameObject VideoCutscene;

    void Start()
    {
        StartCoroutine(Video());
    }

    IEnumerator Video()
    {
        yield return new WaitForSeconds(3);
        VideoCutscene.SetActive(false);
    }
}
