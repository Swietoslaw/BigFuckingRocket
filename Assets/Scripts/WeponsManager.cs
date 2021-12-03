using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeponsManager : MonoBehaviour
{
    int totalWeapons = 1;
    public int currentWeaponIndex;

    public GameObject[] guns;
    public GameObject WeaponHolder;
    private int currentGun;
    public CollisionDetected cD;
    int a = 0;

    // Start is called before the first frame update
    void Start()
    {
        totalWeapons = WeaponHolder.transform.childCount;
        guns = new GameObject[totalWeapons];

        for (int i = 0; i < totalWeapons; i++)
        {
            guns[i] = WeaponHolder.transform.GetChild(i).gameObject;
            guns[i].SetActive(false);
        }

        guns[a].SetActive(true);
       
        currentGun = 0;
        
    }

   
    // Update is called once per frame
    void Update()
    {
        a = cD.whatUHit;

        if(a == 0)
        {
            if(currentGun != a)
            {
                guns[a].SetActive(true);
                guns[currentGun].SetActive(false);             
                currentGun = 0;
            }
        }
           
        
        if(a == 1)
        {
            if (currentGun != a)
            {
                guns[a].SetActive(true);
                guns[currentGun].SetActive(false);               
                currentGun = 1;
            }
        } 
        
        if(a == 2)
        {
            if (currentGun != a)
            {
                guns[a].SetActive(true);
                guns[currentGun].SetActive(false);
                currentGun = 2;
            }
        }
    }
}
