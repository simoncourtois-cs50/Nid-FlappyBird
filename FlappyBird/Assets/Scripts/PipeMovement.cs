using Unity.VisualScripting;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float speed = 2f;
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        Debug.Log("Collide");
    }

    void Update()
    {
        transform.position += speed * Time.deltaTime * Vector3.left;
    }
}
