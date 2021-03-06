﻿using UnityEngine;
using System.Collections;

public class PlaneControl : MonoBehaviour
{
    public GameObject body;

    void Update()
    {
        PlaneEngine engine = GetComponent<PlaneEngine>();
        //engine.thrust += Input.GetAxisRaw("Thrust") * 0.0025f;
        engine.thrust += 0.005f;  // Let's not bother with engine control.

        Animator animator = body.GetComponent<Animator>();
        animator.SetFloat("Pitch", Input.GetAxisRaw("Pitch"));
    }

    void FixedUpdate()
    {
        Rigidbody2D body = GetComponent<Rigidbody2D>();
        body.AddTorque(Input.GetAxisRaw("Pitch") * 800f);
    }
}
