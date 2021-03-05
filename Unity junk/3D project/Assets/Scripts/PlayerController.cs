using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 15.0f;
    private float TurnSpeed = 45f;
    private float horizontalInput;
    private float forewardInput;
    void Start()
    {
        
    }
    
    void Update()
    {
        forewardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        //foreward motion
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forewardInput);
        //turning
        transform.Rotate(Vector3.up, Time.deltaTime * TurnSpeed * horizontalInput);
    }
}
