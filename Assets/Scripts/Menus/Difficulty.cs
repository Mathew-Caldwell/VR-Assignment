using UnityEngine;
using TMPro;

public class Difficulty : MonoBehaviour
{
    public void SetDifficulty()
    {
        string difficulty = gameObject.name;

        TextMeshProUGUI hard;
        TextMeshProUGUI medium;
        TextMeshProUGUI easy;

        Color baseColor = new Color32(255, 0, 156, 255);

        hard = GameObject.Find("HardText").GetComponent<TextMeshProUGUI>();
        medium = GameObject.Find("MediumText").GetComponent<TextMeshProUGUI>();
        easy = GameObject.Find("EasyText").GetComponent<TextMeshProUGUI>();

        switch (difficulty)
        {
            case "Hard":
                DifficultySetter.difficulty = 3;                

                hard.fontMaterial.SetColor("_OutlineColor", new Color32(128,128,128,255));
                medium.fontMaterial.SetColor("_OutlineColor", baseColor);
                easy.fontMaterial.SetColor("_OutlineColor", baseColor);
                break;
            case "Medium":
                DifficultySetter.difficulty = 2;

                hard.fontMaterial.SetColor("_OutlineColor", baseColor);
                medium.fontMaterial.SetColor("_OutlineColor", new Color32(128, 128, 128, 255));
                easy.fontMaterial.SetColor("_OutlineColor", baseColor);
                break;
            case "Easy":
                DifficultySetter.difficulty = 1;

                hard.fontMaterial.SetColor("_OutlineColor", baseColor);
                medium.fontMaterial.SetColor("_OutlineColor", baseColor);
                easy.fontMaterial.SetColor("_OutlineColor", new Color32(128, 128, 128, 255));
                break;
        }
    }
}
