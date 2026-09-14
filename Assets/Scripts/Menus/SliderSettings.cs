using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SliderSettings : MonoBehaviour
{
    public Slider slider; 
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(slider != null)
        {
            slider.value = 0.5f;
        }
    }

    // Update is called once per frame
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

        Debug.Log($"{gameObject.name} {value}");
    }


}
