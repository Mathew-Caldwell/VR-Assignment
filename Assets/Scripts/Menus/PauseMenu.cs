using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    [SerializeField] private InputActionReference pauseButton;
    public bool isVisible = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pauseMenuUI.SetActive(isVisible);
    }

    // Update is called once per frame
    void Update()
    {
        OnEnable();
    }

    private void OnEnable()
    {
        pauseButton.action.started += Pressed;
    }

    private void Pressed(InputAction.CallbackContext context)
    {
        isVisible = !isVisible;
        pauseMenuUI.SetActive(isVisible);
    }
}
