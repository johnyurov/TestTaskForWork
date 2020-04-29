using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;
    [SerializeField]
    private Text scoreResult;
    [SerializeField]
    private Text scoreMax;
    


    private static string scoreCount;
    private static int maximumScore = 0, scoreValue = 0;
    private void Awake()
    {
        if(PlayerPrefs.HasKey("SaveValue"))
        maximumScore = PlayerPrefs.GetInt("SaveValue");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Score"))
        {
            scoreValue++;
            scoreCount = scoreValue.ToString();
            scoreText.text = "Score: " + scoreCount;
            scoreResult.text = scoreCount;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Lose")
        {
            SceneManager.LoadScene(1);
        }
    }


    private void Update()
    {
        
    }
    private void Start()
    {
        if (scoreValue > maximumScore)
        {
            maximumScore = scoreValue;
            scoreMax.text = maximumScore.ToString();
            PlayerPrefs.SetInt("SaveValue", maximumScore);
        }
        else
        {
            scoreMax.text = maximumScore.ToString();
        }
        scoreResult.text = scoreCount;
        //scoreText.text = "Score: " + scoreCount;
    }
}
