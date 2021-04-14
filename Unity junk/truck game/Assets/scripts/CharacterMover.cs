using System.Timers;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMover : MonoBehaviour
{
    public float speed = 3f, gravity = -8f, jumpforce = 3f;

    private float ydirection;
    private int jumpcount, jumpcountmax = 2;
    public CharacterController controller;
    private Vector3 movement, rotation;

    private void Start()
    {
        controller.GetComponent<CharacterController>();
    }

    void Update()
    {
        movement.Set(speed*Input.GetAxis("Vertical"), ydirection, 0);
        rotation.Set(speed*Input.GetAxis("Horizontal"), ydirection, 0);


        ydirection += gravity * Time.deltaTime;

        if (controller.isGrounded && movement.y < 0)
        {
            ydirection = -1f;
            jumpcount = 0;
        }

        if (Input.GetButtonDown("Jump") && jumpcount < jumpcountmax)
        {
            ydirection = jumpforce;
            jumpcount++;
        }

        transform.Rotate(rotation);
        movement = transform.TransformDirection(movement);
        controller.Move(movement * Time.deltaTime);
    }
}
