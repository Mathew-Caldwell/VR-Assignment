using System.Collections;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals;

public class PauseRaycaster : MonoBehaviour
{
    public GameObject Player;
    public GameObject raycastInteractor;
    public GameObject lightSwordR;
    public GameObject lightSwordL;
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

        switch (DifficultySetter.dominantHand)
        {
            case "R":
                lightSwordL.SetActive(isVisible);
                lightSwordR.SetActive(!isVisible);
                break;
            case "L":
                lightSwordL.SetActive(!isVisible);
                lightSwordR.SetActive(isVisible);
                break;
            case "B":
                lightSwordL.SetActive(!isVisible);
                lightSwordR.SetActive(!isVisible);
                break;

        }
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

        switch (DifficultySetter.dominantHand)
        {
            case "R":
                lightSwordR.SetActive(!isVisible);
                break;
            case "L":
                lightSwordL.SetActive(!isVisible);
                break;
            case "B":
                lightSwordL.SetActive(!isVisible);
                lightSwordR.SetActive(!isVisible);
                break;

        }
    }
}
