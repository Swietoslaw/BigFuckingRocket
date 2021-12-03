using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawnController : MonoBehaviour
{
    float rand_position;
    Vector2 spawn_position;
    public float spawnRate = 2f;
    public float nextSpawn = 0f;

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
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            rand_position = Random.Range(-2.4f, 2.4f);
            spawn_position = new Vector2(rand_position, transform.position.y);
            GameObject box = Instantiate(RandomBox(), spawn_position, Quaternion.identity, this.transform);
            Destroy(box, 15);
        }
    }


    // Update is called once per frame
    void Update()
    {
        SpawnEnemy();
    }
}
