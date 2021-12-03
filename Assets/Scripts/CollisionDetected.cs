using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetected : MonoBehaviour
{
    public int whatUHit = 0;
    public int missleHit = 0;
    public Player player;
    private BoxController box;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer != LayerMask.NameToLayer("Projectile") )
        {
            if(collision.gameObject.name == "1misle(Clone)")
            {
                whatUHit = 0;
                Destroy(collision.gameObject);
                
            }
            if(collision.gameObject.name == "2misle(Clone)")
            {
                whatUHit = 1;
                Destroy(collision.gameObject);
                
            }
            if(collision.gameObject.name == "3misle(Clone)")
            {
                whatUHit = 2;
                Destroy(collision.gameObject);
                
            }

            if(collision.gameObject.name == "bomb(Clone)") // name chcange to layer
            {
                box = collision.gameObject.GetComponent<BoxController>();
                missleHit = box.damage;
                Destroy(collision.gameObject);
            }

        }
        
    }

    private void Update()
    {
        int col = player.a;
        if (col > 0)
        {
            missleHit = 0;
        }

    }
}
