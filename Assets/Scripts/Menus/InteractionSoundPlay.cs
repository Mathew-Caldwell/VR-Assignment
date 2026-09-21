using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class InteractionSoundPlay : MonoBehaviour
{
    [SerializeField] XRRayInteractor rayInteractor;
    [SerializeField] AudioSource clickAudio;
    float volume = 0.5f;

    private void Start()
    {
        volume = DifficultySetter.deflectVolume;
        clickAudio.volume = volume;
    }

    public void PlaySoundOnClick()
    {
        if (rayInteractor == null)
        {
            return;
        }
        if (rayInteractor.TryGetCurrentUIRaycastResult(out RaycastResult uiResult))
        {
            UnityEngine.UI.Button button = uiResult.gameObject.GetComponentInParent<UnityEngine.UI.Button>();

            if (button != null)
            {
                clickAudio.Play();
            }
        }
    }
}

