using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Lose")
        {
            Time.timeScale = 0.0F;
            //SceneManager.LoadScene(1);
        }
        if (collision.gameObject.tag == "Player")
        {
            Time.timeScale = 0.0F;
        }
    }
    void Update()
    {
        
    }
}
