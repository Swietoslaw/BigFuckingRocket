using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float fuelUsage;
    public int maxFuel = 100;
    public float currentFuel;

    public FuelScript fuelbar;
    public CollisionDetected cD;
    public int a;

    void Start()
    {
        currentFuel = maxFuel;
    }

    // Update is called once per frame
    void Update()
    {
        FuelUsage();
        
        a = cD.missleHit;
        if (a > 1)
        {
            TakeDamage(a);
        }

    }

    void TakeDamage(int damage)
    {
        currentFuel -= damage;

        fuelbar.SetFuel(currentFuel);
    }

    void FuelUsage()
    {
        currentFuel -= fuelUsage * Time.deltaTime;
        fuelbar.SetFuel(currentFuel);
    }
}
