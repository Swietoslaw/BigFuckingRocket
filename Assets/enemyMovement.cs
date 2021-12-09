using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public float walkSpeed;
    public float walkSpeeddo;
    public Rigidbody2D rb;
    public static GameObject target;

    private void Start()
    {
        target = GameObject.FindWithTag("Player");
    }

    private void FixedUpdate()
    {
        float Playerx = target.transform.position.x;
        float Enemyx = transform.position.x;
        float dir = Enemyx - Playerx;
        
        walkSpeeddo = walkSpeed * -dir;

        Patrol();

    }

    void Patrol()
    {
        rb.velocity = new Vector2(walkSpeeddo * Time.deltaTime, rb.velocity.y);

    }
}
