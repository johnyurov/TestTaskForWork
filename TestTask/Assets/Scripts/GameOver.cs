using UnityEngine;


public class GameOver : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        animator.Play("LoseGame");
    }
}
