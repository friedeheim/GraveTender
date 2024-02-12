using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RunGrabsteinReinigen : MonoBehaviour
{
    public void WechselZuGrab()
    {
        SceneManager.LoadScene("GrabsteinReinigen");
    }

}
