using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Managers;

public class PlayerMove : MonoBehaviour {

    private Rigidbody2D rb;
    private float horizontal;
    [SerializeField] private float movementSpeed;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        horizontal = InputManager.Right() + InputManager.Left();
	}

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * movementSpeed, rb.velocity.y);
    }
}
