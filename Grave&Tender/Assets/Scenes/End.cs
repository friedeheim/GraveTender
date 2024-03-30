using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectActivator : MonoBehaviour
{
    public GameObject beginning;
    public GameObject aboveNineObject;
    public GameObject betweenSixAndNineObject;
    public GameObject belowSixObject;

    public float delayTime = 3f; // Time to wait before activating objects
    private ScoreManager scoreManager; // Reference to the ScoreManager script

    void Start()
    {
        scoreManager = GetComponent<ScoreManager>(); // Get the ScoreManager script attached to the same GameObject
        StartCoroutine(ActivateObjectsWithDelay());
    }

    IEnumerator ActivateObjectsWithDelay()
    {
        yield return new WaitForSeconds(delayTime); // Wait for delayTime seconds

        // Deactivate the "beginning" object
        if (beginning != null)
        {
            beginning.SetActive(false);
        }

        // Get the score from the ScoreManager script
        int score = scoreManager.GetChildScore();

        // Activate objects based on the score
        if (score > 9 && aboveNineObject != null)
        {
            aboveNineObject.SetActive(true);
        }
        else if (score < 6 && belowSixObject != null)
        {
            belowSixObject.SetActive(true);
        }
        else
        {
            betweenSixAndNineObject.SetActive(true);
        }
    }
}
