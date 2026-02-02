using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            FindFirstObjectByType<ScoreManager>().AddPoint();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
