using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject platformPrefab;

    public int numberOfPlatforms;
    public float levelWidth = 3f;
    public float minY = .2f;
    public float maxX = 1.5f;
    void Start()
    {
        Vector3 spawnPosition = new Vector3();
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxX);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);

        }
    }
    void Update()
    {
        
    }
}
