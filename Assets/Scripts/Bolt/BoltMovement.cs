using UnityEngine;

public class BoltMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    GameObject player;
    GameObject spawner;
    bool isDeflected = false;

    // 1 is easy, 2 medium, 3 hard
    int speed;

    Rigidbody rb;

    int speedMultiplier = -20;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        spawner = GameObject.FindWithTag("Spawner");

        speed = spawner.GetComponent<BoltSpawner>().move;

        rb = GetComponent<Rigidbody>();
        rb.linearVelocity = new Vector3(speed * speedMultiplier, 0 , 0);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (player.GetComponent<PauseMenu>().isVisible)
        {
            rb.constraints = RigidbodyConstraints.FreezePositionX;
        }
        else
        {
            rb.constraints = RigidbodyConstraints.None;
            rb.constraints = RigidbodyConstraints.FreezeRotation;
            if (isDeflected)
            {
                rb.constraints = RigidbodyConstraints.FreezePositionY;
                rb.constraints = RigidbodyConstraints.FreezePositionZ;
                rb.linearVelocity = new Vector3(speed * speedMultiplier * -1, 0, 0);
            }
            else
            {
                rb.linearVelocity = new Vector3(speed * speedMultiplier, 0, 0);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("LaserSword"))
        {
            Destroy(GetComponent<Collider>());
            isDeflected = true;
            
            //stops the bolt from moving in any direction other than the x axis
            rb.constraints = RigidbodyConstraints.FreezePositionY;
            rb.constraints = RigidbodyConstraints.FreezePositionZ;

            //stops the bolt from randomly spinning
            rb.freezeRotation = true;

            //disables further collisions
            rb.detectCollisions = false;

            //invertes the velocity of the bolt
            rb.linearVelocity = Vector3.zero;
            rb.linearVelocity = new Vector3(speed * speedMultiplier * -1, 0, 0);
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            //disables further collisions
            Destroy(GetComponent<Collider>());
            rb.detectCollisions = false;
        }
    }
}
