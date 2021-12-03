using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ProjectileControll : MonoBehaviour
{
    public GameObject[] BulletPrefabs;
    private float j = 0;
    public int damage;
    public float timeBetweenShots;


    void Update()
    {
        if (j > 0)
        {
            j = j - Time.deltaTime;
        }
        else
        {
            Shoot();
            j = timeBetweenShots;
        }

    }

    public void Shoot()
    {
        for(int i = 0; i < BulletPrefabs.Length; i++)
        {
            GameObject bullet = Instantiate(BulletPrefabs[i], this.transform.position, transform.rotation);
            Destroy(bullet, 1.5f);
        }
       
    }
}
