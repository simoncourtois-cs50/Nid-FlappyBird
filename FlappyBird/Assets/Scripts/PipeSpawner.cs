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
        // InvokeRepeating(nameof(SpawnPipe), 1f, spawnRate);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        SpawnPipe();
        Debug.Log("Collide");
    }

    void SpawnPipe()
    {
        float RandomY = Random.Range(9.6f, 12f);
        Vector3 spawnPos = new Vector3(transform.position.x, RandomY, 0);
        Instantiate(pipePrefab, spawnPos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
