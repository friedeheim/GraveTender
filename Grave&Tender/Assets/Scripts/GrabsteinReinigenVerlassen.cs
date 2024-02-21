using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GrabsteinReinigenVerlassen : MonoBehaviour
{
    private bool sceneChangeStarted = false;

    void Update()
    {
        // Überprüfen, ob das Particle-System aktiviert ist und die Szeneänderung noch nicht gestartet wurde
        if (gameObject.activeSelf && !sceneChangeStarted)
        {
            sceneChangeStarted = true;
            Invoke("ChangeScene", 5f); // Wechseln der Szene nach 5 Sekunden
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("MainScene01"); // Hier den Namen der Zielszene angeben
    }
}
