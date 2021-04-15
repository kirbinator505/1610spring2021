using System.Timers;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMover : MonoBehaviour
{
    public float speed = 3f, gravity = -8f, jumpforce = 10f;
    public CharacterController controller;

    private float ydirection;
    private int jumpcount, jumpcountmax = 2;
    private Vector3 movement, rotation;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        movement.Set(speed*Input.GetAxis("Vertical"), ydirection, 0);
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

        rotation.y = Input.GetAxis("Horizontal");
        transform.Rotate(rotation);
        movement = transform.TransformDirection(movement);
        controller.Move(movement * Time.deltaTime);
    }
}
