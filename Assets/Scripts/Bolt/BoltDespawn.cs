using UnityEngine;

public class BoltDespawn : MonoBehaviour
{
    public float destroyTime = 0.033333333f;
    float endTime = 0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        endTime = Time.time + destroyTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > endTime)
        {
            Destroy(gameObject);
        }
    }
}
