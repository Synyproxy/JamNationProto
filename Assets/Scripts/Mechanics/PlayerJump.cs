using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Managers;

public class PlayerJump : MonoBehaviour {

    [Range(1, 20)]
    [SerializeField] private float jumpVelocity;
    private Rigidbody2D rb;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (InputManager.Jump() && Mathf.Abs(rb.velocity.y) < 0.01f)
            rb.velocity = new Vector2(0, jumpVelocity);
	}
}
