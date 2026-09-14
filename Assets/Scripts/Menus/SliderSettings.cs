using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class SliderSettings : MonoBehaviour
{
    public Slider slider; 
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (gameObject.name.Contains("Deflect"))
        {
            slider.value = DifficultySetter.deflectVolume;
        }
        else if (gameObject.name.Contains("Hit"))
        {
            slider.value = DifficultySetter.hitVolume;
        }
        else if (gameObject.name.Contains("Brightness"))
        {
            slider.value = DifficultySetter.brightness;
        }
    }


    private void OnEnable()
    {
        slider.onValueChanged.AddListener(OnValueChange);
    }

    private void OnDisable()
    {
        slider.onValueChanged.RemoveListener(OnValueChange);
    }

    void OnValueChange(float value)
    {
        if (gameObject.name.Contains("Deflect"))
        {
            DifficultySetter.deflectVolume = value;
        }
        else if (gameObject.name.Contains("Hit"))
        {
            DifficultySetter.hitVolume = value;
        }
        else if (gameObject.name.Contains("Brightness"))
        {
            DifficultySetter.brightness = value;
        }
    }


}
