using UnityEngine;

public class BoltMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    GameObject player;
    GameObject spawner;
    bool isDeflected = false;

    // 10 is easy, 20 medium,
    float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        spawner = GameObject.FindWithTag("Spawner");
        speed = spawner.GetComponent<BoltSpawner>().move;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<PauseMenu>().isVisible)
        {
            speed = 0;
        }
        else if (isDeflected)
        {
            speed = spawner.GetComponent<BoltSpawner>().move * -1;
        }
        else
        {
            speed = spawner.GetComponent<BoltSpawner>().move;
        }

        Vector3 direction = new Vector3(0, 1, 0);

        transform.Translate(direction * speed * Time.deltaTime);
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
