using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{

    public float zoomSize = 2;
    public Camera camera;

    void Start()
    {
        camera = FindObjectOfType<Camera>();
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            camera.orthographicSize = zoomSize;
        }
    }
}
