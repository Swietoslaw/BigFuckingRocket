using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groupMovement : MonoBehaviour
{
    public float walkSpeed;
    public Rigidbody2D rb;
    private bool dir;
    private int goDown;
    public int downSpeed;

    private void FixedUpdate()
    {

        
        if (transform.position.x > 1 ^ transform.position.x < 0.2)
        {
            walkSpeed = -walkSpeed;
            goDown += 1;
        }
        
        Patrol();

        if (goDown > downSpeed)
        {
            goDown = 0;
            transform.position = transform.position + new Vector3(0, -0.2f, 0);
        }
    }

    void Patrol()
    {
        rb.velocity = new Vector2(walkSpeed * Time.deltaTime, rb.velocity.y);
       
    }
}
