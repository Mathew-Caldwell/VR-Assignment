using UnityEngine;

public class Hide : MonoBehaviour
{
    public bool visible = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.SetActive(visible);
    }
}
