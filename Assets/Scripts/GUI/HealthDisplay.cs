using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    public Image healthColour;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthColour.color = new Color32(0, 0, 255, 11);
    }

    public void UpdateDisplay(int health)
    {
        if (health <= 0)
        {
            healthColour.color = new Color32(150, 150,150, 11);
        }
        else
        {
            float mapB = health * 2.55f;
            float mapR = 255 - (health * 2.55f);
            healthColour.color = new Color32((byte)mapR, 0, (byte)mapB, 11);
        }
    }
}
