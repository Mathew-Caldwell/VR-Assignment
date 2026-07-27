using UnityEngine;

public class BoltMovement : MonoBehaviour
{
    public float move = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x - move, transform.position.y, transform.position.z);
    }
}
