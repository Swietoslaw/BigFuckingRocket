using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxFuel = 100;
    public int currentFuel;

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
}
