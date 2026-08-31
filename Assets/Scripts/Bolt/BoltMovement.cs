using UnityEngine;

public class BoltMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    GameObject player;
    GameObject spawner;
    bool isDeflected = false;

    // 10 is easy, 20 medium,
    float speed;

    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        spawner = GameObject.FindWithTag("Spawner");

        speed = spawner.GetComponent<BoltSpawner>().move;

        rb = GetComponent<Rigidbody>();
        rb.AddForce(spawner.GetComponent<BoltSpawner>().transform.forward * speed * 4000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("LaserSword"))
        {
            Destroy(GetComponent<Collider>());
            
            //stops the bolt from moving in any direction other than the x axis
            rb.constraints = RigidbodyConstraints.FreezePositionY;
            rb.constraints = RigidbodyConstraints.FreezePositionZ;

            //stops the bolt from randomly spinning
            rb.freezeRotation = true;

            //disables further collisions
            rb.detectCollisions = false;

            //invertes the velocity of the bolt
            rb.linearVelocity = Vector3.zero;
            rb.AddForce(spawner.GetComponent<BoltSpawner>().transform.forward * speed * 2000 * -1);            
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            //disables further collisions
            Destroy(GetComponent<Collider>());
            rb.detectCollisions = false;
        }
    }
}
