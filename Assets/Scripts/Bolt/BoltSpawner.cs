using UnityEngine;

public class BoltSpawner : MonoBehaviour
{
    [Header("Bolt Prefabs")]
    public GameObject boltPrefab;
    public GameObject heavyBoltPrefab;
    public GameObject healthBoltPrefab;

    [Header("Spawn Settings")]
    public float waitTime = 1f;
    public float incrementSpawnSpeed = 0.1f;
    public float timeTillNextIncrement = 5f;
    float nextTime = 0f;
    float endTime = 0f;
    public float move = 0.1f;

    [Header("Player Control")]
    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        endTime = Time.time + waitTime;
        nextTime = Time.time + timeTillNextIncrement;
    }

    // Update is called once per frame
    void Update()
    {
        if (CanShoot())
        {
            if (Time.time > endTime)
            {
                if (Time.time > nextTime)
                {
                    waitTime -= incrementSpawnSpeed;
                    nextTime = Time.time + timeTillNextIncrement;
                }

                int boltType = Random.Range(0, 20);
                if (boltType == 19 || boltType == 18)
                {
                    Instantiate(heavyBoltPrefab, new Vector3(transform.position.x, transform.position.y + Random.Range(-0.5f, 0.5f), transform.position.z + Random.Range(-1f, 1f)), Quaternion.Euler(0f, 0f, 90f));
                }
                else if(boltType == 17)
                {
                    Instantiate(healthBoltPrefab, new Vector3(transform.position.x, transform.position.y + Random.Range(-0.5f, 0.5f), transform.position.z + Random.Range(-1f, 1f)), Quaternion.Euler(0f, 0f, 90f));
                }
                else
                {
                    Instantiate(boltPrefab, new Vector3(transform.position.x, transform.position.y + Random.Range(-0.5f, 0.5f), transform.position.z + Random.Range(-1f, 1f)), Quaternion.Euler(0f, 0f, 90f));
                }
                endTime = Time.time + waitTime;


            }
        }
    }

    bool CanShoot()
    {
        if(player.GetComponent<Health>().isDead || player.GetComponent<PauseMenu>().isVisible)
        {
            return false;
        }
        return true;
    }
}
