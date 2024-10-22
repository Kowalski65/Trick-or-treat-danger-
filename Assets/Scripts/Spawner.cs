using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] candies; 
    public float spawnRate = 3; 

    private float lastSpawnTime; 

    void Start()
    {
        lastSpawnTime = Time.time; 
    }

    void Update()
    {
        
        if (Time.time > lastSpawnTime + spawnRate)
        {
            SpawnObject(); 
            lastSpawnTime = Time.time; 
        }
    }

    void SpawnObject()
    {
        if (candies.Length > 0)
        {

            int randomIndex = Random.Range(0, candies.Length);
            GameObject candyToSpawn = candies[randomIndex];
            int randomX = Random.Range(-8, 9);


            float spawnHeight = 5f;
            Vector3 spawnPosition = new Vector3(randomX, spawnHeight, 0);


            Instantiate(candyToSpawn, spawnPosition, Quaternion.identity);
        }
    }
}