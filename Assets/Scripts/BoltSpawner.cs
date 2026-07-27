using UnityEngine;

public class BoltSpawner : MonoBehaviour
{
    [Header("Bolt Prefab")]
    public GameObject bolt;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(bolt, transform.position , Quaternion.identity);
    }
}
