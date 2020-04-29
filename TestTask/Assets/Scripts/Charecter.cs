using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charecter : MonoBehaviour
{
    new Rigidbody2D rigidbody;
    SpriteRenderer spriteRenderer;
    Animator animator;


    [SerializeField]
    private float jumpForce = 7.0F;
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetButtonDown("Jump")) Jump();
    }

   
    private void Jump()
    {
        rigidbody.velocity = Vector2.up * jumpForce;
    }
}
