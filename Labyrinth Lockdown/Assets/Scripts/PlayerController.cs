using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 movement;

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
        movement = new Vector3(Input.GetAxis("Vertical")* -moveSpeed.value, yVar, Input.GetAxis("Horizontal")* moveSpeed.value);
        
        yVar += gravity * Time.deltaTime;

        
        
        if (controller.isGrounded && movement.y < 0)
        {
            yVar = -1f;
            jumpCount = 0;
        }
        else
        {
            transform.parent = null;
            jumpCount = 1;
        }

        if (Input.GetButtonDown("Jump") && jumpCount < playerJumpCount.value)
        {
            yVar = jumpHeight.value;
            jumpCount++;
        }

        movement = transform.TransformDirection(movement);
        controller.Move(movement * Time.deltaTime);
    }
}