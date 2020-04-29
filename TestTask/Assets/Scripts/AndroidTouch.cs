using UnityEngine;

public class AndroidTouch : MonoBehaviour
{
    new Rigidbody2D rigidbody;
    private float jumpForce = 8.0F;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(Input.touchCount > 0)
        {
            rigidbody.velocity = Vector2.up * jumpForce;

        }
    }
}
