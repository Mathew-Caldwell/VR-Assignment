using UnityEngine;

public class Deflect : MonoBehaviour
{
    int numDeflected = 0;

    private AudioSource audioSource;
    public AudioClip deflectSound;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bolt")){
        AudioSource.PlayClipAtPoint(deflectSound, transform.position);
        numDeflected++;
            Debug.Log($"Number deflected: {numDeflected}");
            Destroy(collision.gameObject);
            
        }
    }
}
