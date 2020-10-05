using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float yVar;
    public float jumpCount = 2f;
    public float currentJumpCount;
    public float gravity = 9.138f;
    public float jumpForce = 10f;
    public float rotateSpeed = 10f;
    
    public Vector3 movement;
    public CharacterController controller;

    void Update()
    {
        var hInput = Input.GetAxis("Horizontal")* Time.deltaTime*rotateSpeed;
        transform.Rotate(0,hInput,0);
        
        yVar += gravity * Time.deltaTime;

        if (controller.isGrounded && movement.y < 0)
        {
            yVar = -1f;
            jumpCount = 0;
        }

        if (Input.GetButtonDown("Jump"))

        {
            yVar = jumpForce;
            jumpCount++;
        }
        
        movement = transform.TransformDirection(movement); 
        controller.Move(movement * Time.deltaTime);
    }
}
