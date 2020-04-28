using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charecter : MonoBehaviour
{
    new Rigidbody2D rigidbody;
    SpriteRenderer spriteRenderer;
    Animator animator;
    [SerializeField]
    private float jumpForce = 3.0F;
    [SerializeField]
    private float rightForce = 2.0F;
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
        rigidbody.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        rigidbody.AddForce(transform.right * rightForce, ForceMode2D.Impulse);
    }
}
