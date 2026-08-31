using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 100;
    public bool isDead = false;

    [SerializeField] SceneLoader sceneLoader;

    [Header("GUI")]
    public HealthDisplay healthDisplay;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
        {
            sceneLoader.LoadScene("EndScene");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bolt"))
        {
            int damage = collision.gameObject.GetComponent<BoltStats>().damage;
            UpdateHealth(damage);
        }

        if(health <= 0)
        {
            isDead = true;
        }
    }

    public void UpdateHealth(int damage)
    {
        health -= damage;

        if (health >= 100)
        {
            health = 100;
        }

        healthDisplay.UpdateDisplay(health);
    }
}
