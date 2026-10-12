using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    [SerializeField] private InputActionReference pauseButton;
    public bool isVisible = false;
    [SerializeField ]bool canPause = false;
    float pauseDelay = 1f;
    float endTime = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pauseMenuUI.SetActive(isVisible);
        pauseMenuUI.GetComponent<BoxCollider>().enabled = isVisible;

        endTime = Time.time + pauseDelay;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > endTime)
        {
            canPause = true;
        }
        OnEnable();
    }

    private void OnEnable()
    {
        if (pauseButton != null && canPause)
        {
            pauseButton.action.started += Pressed;
        }
    }

    private void Pressed(InputAction.CallbackContext context)
    {
        isVisible = !isVisible;
        pauseMenuUI.GetComponent<BoxCollider>().enabled = isVisible;
        pauseMenuUI.SetActive(isVisible);
    }

    public void Resume()
    {
        isVisible = !isVisible;
        pauseMenuUI.GetComponent<BoxCollider>().enabled = isVisible;
        pauseMenuUI.SetActive(isVisible);
    }
}
