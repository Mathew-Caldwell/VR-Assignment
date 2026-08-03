using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    [SerializeField] private Button quitGameBttn;

    private void Awake()
    {
        if (quitGameBttn != null)
        {
            quitGameBttn.onClick.AddListener(ButtonClicked);
        }
    }

    void ButtonClicked()
    {
        Application.Quit();
    }

    private void OnDestroy()
    {
        if(quitGameBttn != null)
        {
            quitGameBttn.onClick.RemoveListener(ButtonClicked);
        }
    }
}
