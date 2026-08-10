using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("game quit");
    }
}
