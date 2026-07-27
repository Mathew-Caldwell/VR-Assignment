using UnityEngine;

public class BoltMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    public float move = 0.1f;
    public float incrementMovmentSpeed = 0.1f;
    public float timeTillNextIncreace = 5f;
    float nextTime = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nextTime = Time.time + timeTillNextIncreace;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextTime)
        {
            move += incrementMovmentSpeed;
            nextTime = Time.time + timeTillNextIncreace;
            Debug.Log("Bolt speed increased to: " + move);
        }
        transform.position = new Vector3(transform.position.x - move, transform.position.y, transform.position.z);
    }
}
