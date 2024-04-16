using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs; // Array to store UFO ships
     
    private float zSpawnPos = 20f;
    private float xSpawnRange = 25f;

    private float startDelay = 1f;
    private float spawnInterval = 3f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);// Spawn UFO after a second then after every 3 seconds
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void SpawnRandomUFO()// Method /Function/ to spawn ufo
    {
    
     Vector3 spawnPos = new Vector3(Random.Range(-xSpawnRange, xSpawnRange), 0, zSpawnPos);// Random location on X axis

     int ufoIndex = Random.Range(0, ufoPrefabs.Length);// Index pointer to elements in ufoPrefabs made random and scalable
     Instantiate(ufoPrefabs[ufoIndex], spawnPos, ufoPrefabs[ufoIndex].transform.rotation); // Spawns a UFO based on pointer to element in array
        
    }
}
