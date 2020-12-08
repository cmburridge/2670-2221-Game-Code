using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 movement, lookDirection, velocity;

    public float rotateSpeed = 5f, gravity = -9.81f;
    private float yVar;

    public FloatData moveSpeed;
    public FloatData normalSpeed;
    public FloatData jumpHeight;
        
    public FloatData MoveSpeed => moveSpeed;

    public IntData playerJumpCount;
    private int jumpCount;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        var hInput = Input.GetAxis("Horizontal") * moveSpeed.value * Time.deltaTime;
        var vInput = Input.GetAxis("Vertical") * moveSpeed.value * Time.deltaTime;

        movement.Set(hInput, 0, newZ: vInput);

        lookDirection.Set(hInput, 0, vInput);
        
        if (hInput > 0.0001f || hInput < -0.00001f || vInput > 0.00001f || vInput < -0.00001f)
        {
            transform.rotation = Quaternion.LookRotation(lookDirection);
        }
        
        if (lookDirection == Vector3.zero)
        {
            lookDirection.Set(0.0001f * Time.deltaTime, 0, 0.0001f * Time.deltaTime);
        }

        if (!controller.isGrounded)
        {
            transform.parent = null;
            playerJumpCount.value = 0;
        }

        if (controller.isGrounded)
        {
            playerJumpCount.value = 1;
        }
        
        controller.Move(movement);
        
        controller.Move(movement * Time.deltaTime);

        if (controller.isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if (Input.GetButtonDown("Jump") && playerJumpCount.value == 1)
        {
            velocity.y = Mathf.Sqrt(jumpHeight.value * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}