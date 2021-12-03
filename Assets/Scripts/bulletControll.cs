using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletControll : MonoBehaviour
{
    private Rigidbody2D rb; 
    public float speed;
    public Vector2 bulletDir;
    public float bulletRotation;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = bulletDir * speed;
        rb.rotation = bulletRotation;
      
    }

}
