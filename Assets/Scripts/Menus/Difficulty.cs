using UnityEngine;

public class Difficulty : MonoBehaviour
{
    public void SetDifficulty()
    {
        string difficulty = gameObject.name;

        switch (difficulty)
        {
            case "Hard":
                DifficultySetter.difficulty = 3;
                break;
            case "Medium":
                DifficultySetter.difficulty = 2;
                break;
            case "Easy":
                DifficultySetter.difficulty = 1;
                break;
        }
    }
}
