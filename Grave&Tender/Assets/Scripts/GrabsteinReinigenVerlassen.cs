using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GrabsteinReinigenVerlassen : MonoBehaviour
{
    private bool sceneChangeStarted = false;
    public GameObject CanvasON;
    public GameObject CanvasOFF;

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
        // Finde die Kamera mit dem Namen "Main Camera (Reinigen)"
        GameObject cameraObject = GameObject.Find("Main Camera (Reinigen)");

        // Überprüfen, ob die Kamera gefunden wurde
        if (cameraObject != null)
        {
            // Deaktiviere die Kamera
            cameraObject.SetActive(false);
            CanvasOFF.gameObject.SetActive(false);
            CanvasON.gameObject.SetActive(true);
        }
       
    }
}
