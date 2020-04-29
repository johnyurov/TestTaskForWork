using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    
    public Text scoreText;
    string scoreCount;
    int scoreValue = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals("Score"))
        {
            scoreValue++;
            scoreCount = scoreValue.ToString();
            scoreText.text = "Score: " + scoreCount;  
        }
    }
    private void Start()
    {
        scoreText.text = "Score: " + scoreCount;
    }
}
