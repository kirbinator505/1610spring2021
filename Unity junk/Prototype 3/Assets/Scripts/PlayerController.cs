using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpforce = 10f, gravityModifier;
    public bool isonground = true;
    
    private Rigidbody playerRB;
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isonground)
        {
            playerRB.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            isonground = false;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        isonground = true;
    }
}
