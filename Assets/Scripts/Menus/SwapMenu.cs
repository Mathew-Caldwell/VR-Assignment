using UnityEngine;

public class SwapMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settings;

    bool isVisible = true;

    void Start()
    {
        mainMenu.SetActive(isVisible);
        settings.SetActive(!isVisible);
    }

    public void ToSettings()
    {
        settings.SetActive(isVisible);
        mainMenu.SetActive(!isVisible);
    }

    public void ToMainMenu()
    {
        mainMenu.SetActive(isVisible);
        settings.SetActive(!isVisible);
    }
}
