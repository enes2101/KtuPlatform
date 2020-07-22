using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    
    public float speed;
    
    void Update()
    {
        Movement();
    }
    private void Movement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = transform.TransformDirection(transform.right) * moveHorizontal;

        transform.position += movement * Time.deltaTime * speed;

        if (moveHorizontal>0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
