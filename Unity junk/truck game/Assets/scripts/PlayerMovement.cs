using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D ballRigidbody2D;
    private Vector2 direction;
    private Vector2 ydirection;

    public float speed = 3f;

    public float jumpForce = 300f;
    // Start is called before the first frame update
    void Start()
    {

    
    }

    // Update is called once per frame
    void Update()
    {
      /*  if (Input.GetKey(KeyCode.LeftArrow))
        {
            ballRigidbody2D.AddForce(-direction, ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            ballRigidbody2D.AddForce(direction, ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            ballRigidbody2D.AddForce(ydirection, ForceMode2D.Force);
        }
        */
      direction.x = Input.GetAxis("Horizontal") * speed;
      ballRigidbody2D.AddForce(direction, ForceMode2D.Force);
      
      if (Input.GetButtonDown("Jump"))
      {
          ydirection.y = jumpForce;
          ballRigidbody2D.AddForce(ydirection, ForceMode2D.Force);
      }
    }
}
