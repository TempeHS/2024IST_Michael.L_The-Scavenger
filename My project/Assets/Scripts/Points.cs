using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Points : MonoBehaviour
{
    public static Points instance;
    public Text scoreText;
    public int score = 0;

    void Awake()
    {
        instance = this;
    }

    void Start() 
    {
        scoreText.text = score.ToString();
    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString();
    }

}
