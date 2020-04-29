using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnMove : MonoBehaviour
{
    [SerializeField]
    private float speed = 2.0F;

    void Update()
    {
        transform.Translate(-speed,0,0);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            speed = 0.0F;
            if (gameObject.tag == "Lose")
            {
                Debug.Log("ysdc");
                speed = 0.0F;
            }
            Time.timeScale = 0.0F;
        }
    }
    
}
