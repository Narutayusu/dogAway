using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //public Transform player;
    //public TMP_Text scoretext;
    public static int scoreCount;
    public Text ScoreText;
    private void Update()
    {
        //scoretext.text = player.position.z.ToString("0.0")+"m";
        ScoreText.text = "Score: " + Mathf.Round(scoreCount);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "coin")
        {
            Score.scoreCount += 1;
        }
    }
}
