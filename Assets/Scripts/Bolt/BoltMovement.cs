using UnityEngine;

public class BoltMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    GameObject player;
    GameObject spawner;
    bool isDeflected = false;
    float move;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        spawner = GameObject.FindWithTag("Spawner");
        move = spawner.GetComponent<BoltSpawner>().move;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<PauseMenu>().isVisible)
        {
            move = 0;
        }
        else if (isDeflected)
        {
            move = spawner.GetComponent<BoltSpawner>().move * -1;
        }
        else
        {
            move = spawner.GetComponent<BoltSpawner>().move;
        }
        transform.position = new Vector3(transform.position.x - move, transform.position.y, transform.position.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("LaserSword"))
        {
            isDeflected = true;
            Destroy(GetComponent<Collider>());
            
        }
    }
}
