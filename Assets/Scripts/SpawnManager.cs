﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnPosZ = 12.0f;
    private float spawnRangeX = 12.0f;
    private float startDelay = 2.0f;
    private float startInterval = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpwanRandomAnimals", startDelay, startInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void SpwanRandomAnimals()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
