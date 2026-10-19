using TMPro;
using UnityEngine;
using UnityEngine.XR;

public class HandSelector : MonoBehaviour
{
    public void HandSelected()
    {
        string hand = gameObject.name;

        TextMeshProUGUI left;
        TextMeshProUGUI both;
        TextMeshProUGUI right;

        Color baseColor = new Color32(255, 0, 156, 255);

        left = GameObject.Find("LeftText").GetComponent<TextMeshProUGUI>();
        both = GameObject.Find("BothText").GetComponent<TextMeshProUGUI>();
        right = GameObject.Find("RightText").GetComponent<TextMeshProUGUI>();

        switch (hand)
        {
            case "Left Hand":
                DifficultySetter.dominantHand = "L";
                left.fontMaterial.SetColor("_OutlineColor", new Color32(128, 128, 128, 255));
                both.fontMaterial.SetColor("_OutlineColor", baseColor);
                right.fontMaterial.SetColor("_OutlineColor", baseColor);
                break;
            case "Right Hand":
                DifficultySetter.dominantHand = "R";
                left.fontMaterial.SetColor("_OutlineColor", baseColor);
                both.fontMaterial.SetColor("_OutlineColor", baseColor);
                right.fontMaterial.SetColor("_OutlineColor", new Color32(128, 128, 128, 255));
                break;
            case "Both Hands":
                DifficultySetter.dominantHand = "B";
                left.fontMaterial.SetColor("_OutlineColor", baseColor);
                both.fontMaterial.SetColor("_OutlineColor", new Color32(128, 128, 128, 255));
                right.fontMaterial.SetColor("_OutlineColor", baseColor);
                break;
        }
    }
}
