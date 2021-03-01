using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D ballRigidbody2D;
    private Vector2 direction;
    private Vector2 ydirection;

    public float speed = 3f;

    public float jumpForce = 300f;
    // Start is called before the first frame update
    void Start()
    {
        ballRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    direction.x = Input.GetAxis("Horizontal") * speed;
      ballRigidbody2D.AddForce(direction, ForceMode2D.Force);
      
      if (Input.GetButtonDown("Jump"))
      {
          ydirection.y = jumpForce;
          ballRigidbody2D.AddForce(ydirection, ForceMode2D.Force);
      }
    }
}
