using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    AudioSource sPlay;
    [SerializeField]
    private Text scoreText;
    private static string scoreCount;
    public static int scoreValue;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Score"))
        {
            scoreValue++;
            scoreCount = scoreValue.ToString();
            scoreText.text = "Score: " + scoreCount;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Lose")
        {
            SceneManager.LoadScene(2);
        }
    }
    private void Start()
    {
        sPlay = GetComponent<AudioSource>();
        scoreValue = 0;
    }
}
