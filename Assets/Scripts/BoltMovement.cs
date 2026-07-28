using UnityEngine;

public class BoltMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    public float move = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x - move, transform.position.y, transform.position.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("LaserSword"))
        {
            move *= -1;
        }
    }
}
