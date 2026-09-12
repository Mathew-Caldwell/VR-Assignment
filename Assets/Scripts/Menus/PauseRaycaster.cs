using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals;

public class PauseRaycaster : MonoBehaviour
{
    public GameObject Player;
    public GameObject raycastInteractor;
    public GameObject lightSword;
    bool isVisible;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        XRInteractorLineVisual visuliser = raycastInteractor.GetComponent<XRInteractorLineVisual>();

        isVisible = false;

        if (Player.GetComponent<PauseMenu>() != null)
        {
            isVisible = Player.GetComponent<PauseMenu>().isVisible;
        }
        
        visuliser.enabled = isVisible;
        lightSword.SetActive(!isVisible);
    }

    // Update is called once per frame
    void Update()
    {
        XRInteractorLineVisual visuliser = raycastInteractor.GetComponent<XRInteractorLineVisual>();

        isVisible = false;

        if (Player.GetComponent<PauseMenu>() != null)
        {
            isVisible = Player.GetComponent<PauseMenu>().isVisible;
        }

        visuliser.enabled = isVisible;
        lightSword.SetActive(!isVisible);
    }
}
