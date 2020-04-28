using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    new Rigidbody2D rigidbody;
    Animator animator;
    SpriteRenderer spriteRenderer;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Lose"))
        {
          //  Time.timeScale = 0.0F;
            animator.Play("LoseGame");
        }
    }
    
    void Update()
    {
        
    }
}
