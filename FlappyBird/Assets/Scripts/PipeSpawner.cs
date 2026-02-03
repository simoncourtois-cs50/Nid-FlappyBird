
using UnityEngine;
using Random = UnityEngine.Random;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    
    public float _spawnRate = 2f;
    public float[] _challengesY = {14.6f, 7.53f};
    public int m_challengeOccurence = 5;
    
    private int _pipeCounter = 0;
    

void Start()
    {
        InvokeRepeating(nameof(SpawnPipe), 1f, _spawnRate);

    }

 

    void SpawnPipe()
    {
        float randomY = Random.Range(9.6f, 12f);
        
        _pipeCounter++;
        
        if (_pipeCounter % m_challengeOccurence == 0)
        {
            int index = Random.Range(0, _challengesY.Length);
            randomY = _challengesY[index];

        }
            
        Vector3 spawnPos = new Vector3(pipePrefab.transform.position.x, randomY, 0);
        Instantiate(pipePrefab, spawnPos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
