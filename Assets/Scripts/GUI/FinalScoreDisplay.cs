using TMPro;
using UnityEngine;

public class FinalScoreDisplay : MonoBehaviour
{
    public TMP_Text scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = ScoreData.score;
        scoreText.text = $"{score} X";
    }
}
