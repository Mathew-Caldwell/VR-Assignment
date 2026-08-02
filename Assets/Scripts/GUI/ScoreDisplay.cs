using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TMP_Text scoreText;
    string score = "";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void UpdateScore(int score)
    {
        this.score = $"{score} X";
        UpdateDisplay();
    }

    void UpdateDisplay()
    {
        scoreText.text = score;
    }
}
