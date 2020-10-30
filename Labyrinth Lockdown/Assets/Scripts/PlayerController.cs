using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 movement;

    public float rotateSpeed = 5f, gravity = -9.81f, jumpForce = 10f;
    private float yVar;

    public FloatData moveSpeed, fastSpeed;
    public FloatData normalSpeed;

    public FloatData MoveSpeed => moveSpeed;

    public IntData playerJumpCount;
    private int jumpCount;

    private void Start()
    {
        moveSpeed = normalSpeed;
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        { 
            var vInput = Input.GetAxis("Vertical") * moveSpeed.value; 
            movement.Set(vInput, yVar, 0);
        }

        var hInput = Input.GetAxis("Horizontal") * Time.deltaTime * rotateSpeed;
        transform.Rotate(0, hInput, 0);

        yVar += gravity * Time.deltaTime;

        if (controller.isGrounded && movement.y < 0)
        {
            yVar = -1f;
            jumpCount = 0;
            moveSpeed = fastSpeed;
        }
        else
        {
            moveSpeed = normalSpeed;
            transform.parent = null;
            jumpCount = 1;
        }

        if (Input.GetButtonDown("Jump") && jumpCount < playerJumpCount.value)
        {
            yVar = jumpForce;
            jumpCount++;
        }

        movement = transform.TransformDirection(movement);
        controller.Move(movement * Time.deltaTime);

        if (Input.GetButton("Fire2"))
        {
            Camera.main.orthographic = true;
        }
        else
        {
            Camera.main.orthographic = false;
        }
    }
}