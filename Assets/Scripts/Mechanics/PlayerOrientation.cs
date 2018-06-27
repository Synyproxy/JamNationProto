using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Managers;

public class PlayerOrientation : MonoBehaviour {

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update ()
    {
        if (InputManager.Right() != 0)
            spriteRenderer.flipX = false;
        if(InputManager.Left() != 0)
            spriteRenderer.flipX = true;
    }
}
