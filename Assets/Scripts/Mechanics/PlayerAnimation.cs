using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Managers;

public class PlayerAnimation : MonoBehaviour {

    private Animator animator;
    private Rigidbody2D rb;

	// Use this for initialization
	void Start ()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (InputManager.Right() != 0 || InputManager.Left() != 0)
            animator.SetBool("isRunning", true);
            
        else
            animator.SetBool("isRunning", false);

        if (Mathf.Abs(rb.velocity.y) < 0.01f)
            animator.SetBool("isJumping", false);

        else
            animator.SetBool("isJumping", true);
    }
}
