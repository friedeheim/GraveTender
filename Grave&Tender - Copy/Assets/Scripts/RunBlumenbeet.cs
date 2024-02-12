using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RunBlumenbeet : MonoBehaviour
{
    public void PlayBlumenbeet()
    {
        SceneManager.LoadScene("Part1BlumenPflanzen");
    }
}
