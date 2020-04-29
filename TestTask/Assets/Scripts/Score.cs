using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;
    [SerializeField]
    private Text scoreResult;
    [SerializeField]
    private Text scoreMax;
    [SerializeField]
    private GameObject pauseMenuUI;


    private string scoreCount;
    private bool visiableTable = false;
    private int maximumScore = 0, scoreValue = 0;
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
            if (!visiableTable)
            {
               // Resume();
                Pause();
            }
            else
            {
            }
        }
    }
    //public void Resume()
    //{
    //    pauseMenuUI.SetActive(false);
    //    Time.timeScale = 1F;
    //    visiableTable = false;
    //}

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0F;
        visiableTable = true;
    }
    private void Update()
    {
        if (scoreValue > maximumScore)
        {
            maximumScore = scoreValue;
            scoreMax.text = maximumScore.ToString();
            PlayerPrefs.SetInt("SaveValue", maximumScore);
        }
        else
            scoreMax.text = maximumScore.ToString();
    }
    private void Start()
    {
        scoreText.text = "Score: " + scoreCount;
    }
}
