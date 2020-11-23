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
    
    bool GetAnyKey(params KeyCode[] aKeys)
    {
        foreach(var key in aKeys)
            if (Input.GetKey(key))
                return true;
        return false;
    }
    
    private void Update()
    {
        float moveHorizontal = Input.GetAxisRaw ("Horizontal");
        float moveVertical = Input.GetAxisRaw ("Vertical");
        
        
        Vector3 movement = new Vector3(moveHorizontal, yVar, moveVertical);
        
        Vector3 direction = new Vector3(moveHorizontal,0,moveVertical);
        
        transform.rotation = Quaternion.LookRotation(direction);

        controller.Move(Time.deltaTime * moveSpeed.value * movement);

        if (this.transform.rotation == Quaternion.identity)
        {
            transform.rotation = Quaternion.Euler(0,0,0);
        }

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
    }
}