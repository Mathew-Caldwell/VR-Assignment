using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSwapper : MonoBehaviour
{
    public void SwapMenu(string menuName)
    {
        gameObject.SetActive(false);
        GameObject nextMenu = GameObject.Find(menuName);
        nextMenu.SetActive(true);
    }
}
