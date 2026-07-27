using UnityEngine;

public class BoltSpawner : MonoBehaviour
{
    [Header("Bolt Prefab")]
    public GameObject bolt;
    public float waitTime = 5f;
    float endTime = 0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        endTime = Time.time + waitTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > endTime)
        {
            Instantiate(bolt, new Vector3(transform.position.x, transform.position.y + Random.Range(-1f, 1f), transform.position.z + Random.Range(-1f, 1f)), Quaternion.identity);
            endTime = Time.time + waitTime;

            
        }
    }
}
