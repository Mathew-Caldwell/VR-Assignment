using UnityEngine;

public class Deflect : MonoBehaviour
{
    int numDeflected = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bolt")){
            numDeflected++;
            Debug.Log($"Number deflected: {numDeflected}");
            Destroy(collision.gameObject);
        }
    }
}
