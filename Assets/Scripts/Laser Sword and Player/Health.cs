using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 100;

    [Header("GUI")]
    public HealthDisplay healthDisplay;

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
            int damage = collision.gameObject.GetComponent<BoltStats>().damage;
            health -= damage;

            healthDisplay.UpdateDisplay(health);
        }
    }
}
