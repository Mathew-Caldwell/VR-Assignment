using UnityEngine;

public class HandSelector : MonoBehaviour
{
    public void HandSelected()
    {
        string hand = gameObject.name;
        Debug.Log("Hand selected: " + hand);
        switch (hand)
        {
            case "Left Hand":
                DifficultySetter.dominantHand = "L";
                break;
            case "Right Hand":
                DifficultySetter.dominantHand = "R";
                break;
            case "Both Hands":
                DifficultySetter.dominantHand = "B";
                break;
        }
    }
}
