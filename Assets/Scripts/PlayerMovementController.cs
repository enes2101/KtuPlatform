using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    
    public float speed;
    public Rigidbody rb;
    public float jumpForce;
    bool isGrounded = true;

    void Update()
    {
        JumpInput();
        Movement();
        CursorLockAndOpen();
    }

    public void JumpInput()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void Movement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = transform.TransformDirection(transform.right) * moveHorizontal;

        transform.position += movement * Time.deltaTime * speed;

        //if (moveHorizontal > 0)
        //{
        //    transform.rotation = Quaternion.Euler(0, 180, 0);
        //}
        //else
        //{
        //    transform.rotation = Quaternion.Euler(0, 0, 0);
        //}
    }
    private static void CursorLockAndOpen()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
