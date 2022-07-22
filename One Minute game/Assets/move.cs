using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;
    public float jump;
    public Rigidbody rb;
    public int maxCubeCount;
    [System.NonSerialized]
    public int cubeCount;
    public Transform oritents;
    
    float horizontal;
    float vertical;

    Vector3 moveDirection;

   

    private void Update()
    {
         horizontal = Input.GetAxisRaw("Horizontal");
         vertical = Input.GetAxisRaw("Vertical");
        
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(0, jump, 0, ForceMode.Impulse);
        }

    }

    private void FixedUpdate()
    {
        moveDirection = oritents.forward * vertical + oritents.right * horizontal;
        rb.AddForce(moveDirection.normalized * speed * 10f, ForceMode.Impulse);
                
    }
}
