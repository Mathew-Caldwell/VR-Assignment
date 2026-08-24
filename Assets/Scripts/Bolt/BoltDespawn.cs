using UnityEngine;

public class BoltDespawn : MonoBehaviour
{
    public float destroyTime = 0.033333333f;
    float endTime = 0f;

    public GameObject player;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        endTime = Time.time + destroyTime;

        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<PauseMenu>().isVisible && gameObject.tag == "Bolt")
        {
            endTime = Time.time + 10;
        }
        Decay();
    }

    void Decay()
    {
        if (Time.time > endTime)
        {
            Destroy(gameObject);
        }
    }
}
