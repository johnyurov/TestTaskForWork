using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxScore : MonoBehaviour
{
    AudioSource sPlay;
    [SerializeField]
    private AudioClip hit;
    [SerializeField]
    private Text scoreResult;
    [SerializeField]
    private Text scoreMax;
    private Score score;

    private static string scoreCount;
    private static int maximumScore = 0, scoreValue;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("SaveValue"))
            maximumScore = PlayerPrefs.GetInt("SaveValue");
    }
    void Start()
    {
        GetComponent<AudioSource>().PlayOneShot(hit);
        scoreCount = Score.scoreValue.ToString();
        scoreResult.text = scoreCount;
    }

    void Update()
    {
        scoreValue = Score.scoreValue;
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
    }
}
