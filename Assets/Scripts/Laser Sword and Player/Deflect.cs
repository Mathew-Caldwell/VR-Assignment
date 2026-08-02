using UnityEngine;

public class Deflect : MonoBehaviour
{
    [Header("Audio")]
    private AudioSource audioSource;
    public AudioClip deflectSound;

    [Header("Effects")]
    public GameObject hitEffectPrefab;

    int score = 0;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bolt"))
        {
            AudioSource.PlayClipAtPoint(deflectSound, transform.position);
            Instantiate(hitEffectPrefab, collision.contacts[0].point, Quaternion.identity);
            score += collision.gameObject.GetComponent<BoltStats>().scoreValue;
        }
    }
}
