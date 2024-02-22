using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RunUnkraut : MonoBehaviour
{
    public void PlayUnkraut()
    {
        SceneManager.LoadScene("Part1BlumenPflanzen");
    }
}
