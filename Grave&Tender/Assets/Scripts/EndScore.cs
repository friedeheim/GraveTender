using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance; // Singleton instance

    private int graveScore = 0; // Score counter for graves
    private int childScore = 0; // Score counter for children

    private void Awake()
    {
        // Ensure only one instance of ScoreManager exists
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Don't destroy this object when loading a new scene
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate instances
        }
    }

    private void Start()
    {
        // Load the scores from PlayerPrefs if they exist
        if (PlayerPrefs.HasKey("GraveScore"))
        {
            graveScore = PlayerPrefs.GetInt("GraveScore");
        }
        if (PlayerPrefs.HasKey("ChildScore"))
        {
            childScore = PlayerPrefs.GetInt("ChildScore");
        }
    }

    private void OnDestroy()
    {
        // Save the scores to PlayerPrefs when the object is destroyed
        PlayerPrefs.SetInt("GraveScore", graveScore);
        PlayerPrefs.SetInt("ChildScore", childScore);
    }

    // Method to increase the grave score
    public void IncreaseGraveScore(int amount)
    {
        graveScore += amount;
    }

    // Method to increase the child score
    public void IncreaseChildScore(int amount)
    {
        childScore += amount;
    }

    // Method to get the current grave score
    public int GetGraveScore()
    {
        return graveScore;
    }

    // Method to get the current child score
    public int GetChildScore()
    {
        return childScore;
    }
}

