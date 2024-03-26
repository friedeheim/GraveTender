using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreConversation : MonoBehaviour
{
    public void Score()
    {
        // Add one to the child score
        ScoreManager.instance.IncreaseChildScore(1);

        // Log the current child score
        Debug.Log("Current Child Score: " + ScoreManager.instance.GetChildScore());
    }
}
