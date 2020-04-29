using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Lose")
        {
            Debug.Log("ysdc");  
            Time.timeScale = 0.0F;
        }
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("dfgdc");
            Time.timeScale = 0.0F;
        }
    }
    void Update()
    {
        
    }
}
