using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GebetVerlassen : MonoBehaviour
{
    public void Verlassen()
    {
        SceneManager.LoadScene("MainScene");
    }

}
