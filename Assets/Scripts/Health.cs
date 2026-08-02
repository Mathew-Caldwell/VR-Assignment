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
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bolt"))
        {
            int damage = collision.gameObject.GetComponent<BoltDamage>().damage;
            health -= damage;

            Debug.Log($"Player got hit by {collision.gameObject.name} and health is now at {health}");
        }
    }
}
