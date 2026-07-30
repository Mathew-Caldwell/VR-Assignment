using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bolt"))
        {
            if (collision.gameObject.name == "Heavy Bolt(Clone)")
            {
                health -= 20;
                Debug.Log($"Hit by {collision.gameObject.name}, health is now {health}");
            }
            else
            {
                health -= 10;
                Debug.Log($"Hit by {collision.gameObject.name}, health is now {health}");
            }
        }
    }
}
