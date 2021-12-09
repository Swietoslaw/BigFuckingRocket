using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    Vector2 spawn_position;
    public float spawnRatt;
    public float randomnessMax;
    public float randomnessMin;
    public bool randomSpawnRate;
    private float spawnRate;
    private float nextSpawn;

    public GameObject[] enemyList;
    private GameObject randomBox;

    private GameObject RandomBox()
    {
        var randomTemp = Random.Range(0, enemyList.Length);

        for (int i = 0; i < enemyList.Length; i++)
        {
            if (i == randomTemp)
            {
                randomBox = enemyList[i];
            }
        }

        return randomBox;
    }

    private void SpawnEnemy()
    {
        if (randomSpawnRate)
        {
            spawnRate = spawnRatt * Random.Range(randomnessMin, randomnessMax);
        }
        else
        {
            spawnRate = spawnRatt;
        }
        

        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            spawn_position = new Vector2(transform.position.x, transform.position.y);
            GameObject box = Instantiate(RandomBox(), spawn_position, Quaternion.identity);
            Destroy(box, 15);
        }
    }

    private void Start()
    {
        nextSpawn = Random.Range(3f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnemy();
    }
}
