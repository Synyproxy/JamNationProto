using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Managers;

public class PlayerJump : MonoBehaviour {

    [Range(1, 20)]
    [SerializeField] private float jumpVelocity;
    [SerializeField] private float fallMultiplier = 2.5f;
    [SerializeField] private float lowJumpMultiplier = 2f;

    private Rigidbody2D rb;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log(rb.velocity.y);

        if (InputManager.Jump() && Mathf.Abs(rb.velocity.y) < 0.01f)
            rb.velocity = new Vector2(0, jumpVelocity);
            //rb.velocity = Vector2.up * jumpVelocity;
	}

    private void FixedUpdate()
    {
        //if (rb.velocity.y < 0)
        //    rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        //else if(rb.velocity.y > 0 && !InputManager.Jump())
        //    rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
    }
}
