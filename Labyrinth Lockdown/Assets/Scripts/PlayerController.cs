using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 movement, lookDirection;

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

        movement.Set(hInput, yVar, newZ: vInput);

        lookDirection.Set(hInput, 0, vInput);
        
        if (hInput > 0.0001f || hInput < -0.00001f || vInput > 0.00001f || vInput < -0.00001f)
        {
            transform.rotation = Quaternion.LookRotation(lookDirection);
        }
        
        if (lookDirection == Vector3.zero)
        {
            lookDirection.Set(0.0001f * Time.deltaTime, 0, 0.0001f * Time.deltaTime);
        }
        
        movement.y = yVar;
        
        controller.Move(movement);
        if (!controller.isGrounded)
        {
           yVar += gravity * Time.deltaTime; 
        }

        if (controller.isGrounded && movement.y < 0)
        {
            yVar = -1f;
            jumpCount = 0;
        }
        
        if (Input.GetButtonDown("Jump"))

        {
            if (jumpCount < playerJumpCount.value)
            {
                yVar = jumpHeight.value * Time.deltaTime;
                jumpCount++;
            }
        }
        
        lookDirection.Set(hInput, 0, vInput);

        if (lookDirection == Vector3.zero)
        {
            lookDirection.Set(0.0001f, 0, 0.0001f);
        }
        
        if (hInput > 0.1f || hInput < -0.1f ||vInput > 0.1f || vInput < -0.1f)
        {
            transform.rotation = Quaternion.LookRotation(lookDirection);
        }
        
        if (controller.isGrounded && Input.GetButton("Jump")) {
            movement.y = yVar;
        }
        movement.y -= gravity * Time.deltaTime;
        controller.Move(movement * Time.deltaTime);
    }
}