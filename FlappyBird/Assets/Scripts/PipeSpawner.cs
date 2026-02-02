using System;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2f;
    void Start()
    {
        InvokeRepeating(nameof(SpawnPipe), 1f, spawnRate);

    }

 

    void SpawnPipe()
    {
        float RandomY = Random.Range(9.6f, 12f);
        Vector3 spawnPos = new Vector3(pipePrefab.transform.position.x, RandomY, 0);
        Instantiate(pipePrefab, spawnPos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
