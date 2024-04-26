using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
    private void Start()
    {
        score = 0;
    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "coin")
        {
            score++;
            scoreText.text = "Score : " + score;
            Destroy(other.gameObject);
            
        }
    }
    
}
