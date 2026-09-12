using UnityEngine;

public class Deflect : MonoBehaviour
{
    [Header("Audio")]
    [SerializeField] private AudioSource audioSource;

    [Header("Game Objects")]
    public GameObject hitEffectPrefab;
    public GameObject player;

    [Header("GUI")]
    public ScoreDisplay scoreDisplay;

    int score = 0;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        scoreDisplay.UpdateScore(score);
    }
private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bolt"))
        {
            audioSource.pitch = Random.Range(0.9f, 1.2f);
            audioSource.Play();

            Instantiate(hitEffectPrefab, collision.contacts[0].point, Quaternion.identity);

            score += collision.gameObject.GetComponent<BoltStats>().scoreValue;
            scoreDisplay.UpdateScore(score);

            if(collision.gameObject.name == "Health Bolt(Clone)")
            {
                player.GetComponent<Health>().UpdateHealth(-collision.gameObject.GetComponent<BoltStats>().healValue);
            }
        }
    }
}
