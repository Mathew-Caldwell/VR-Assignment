using UnityEngine;

public class BoltMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    public float move = 0.1f;
    GameObject player;
    bool isDeflected = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player");
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
            move = -0.1f;
        }
        else
        {
            move = 0.1f;
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
