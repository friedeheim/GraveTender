using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RunGebetDalassen : MonoBehaviour
{
    public void WechselZuGebet()
    {
        SceneManager.LoadScene("GebetDalassen");
    }

}
