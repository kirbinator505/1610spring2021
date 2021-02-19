using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detection : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("in");
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("out");
    }
}
