﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepUp : MonoBehaviour
{
    public Rigidbody2D ballRigidbody2D;
    private Vector2 direction;
    private Vector2 ydirection;
    public float forceup = 2f;
    public float forceside = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while (true)
        {
            ydirection.y = forceup;
            ballRigidbody2D.AddForce(ydirection, ForceMode2D.Force);
        }
    }
}
