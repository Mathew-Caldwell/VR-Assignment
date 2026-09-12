using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 100;
    [SerializeField] int maxHealth = 100;
    public bool isDead = false;

    [Header("Audio")]
    [SerializeField] private AudioSource audioSource;

    [SerializeField] SceneLoader sceneLoader;

    [Header("GUI")]
    public HealthDisplay healthDisplay;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isDead = false;
        audioSource = GetComponent<AudioSource>();
        health = maxHealth;
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
            audioSource.pitch = Random.Range(0.6f, 0.7f);
            audioSource.Play();

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

        if (health >= maxHealth)
        {
            health = maxHealth;
        }

        healthDisplay.UpdateDisplay(health);
    }
}
