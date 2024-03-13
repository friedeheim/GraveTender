using UnityEngine;
using UnityEngine.SceneManagement;

public class GrabsteinReinigenVerlassen : MonoBehaviour
{
    private bool sceneChangeStarted = false;
    public GameObject CanvasON;
    public GameObject CanvasOFF;
    public GameObject CameraON;
    public GameObject CameraOFF;

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
        // Überprüfen, ob die Kameraobjekte gültig sind
        if (CameraOFF != null && CameraON != null)
        {
            // Deaktiviere die "CameraOFF" und aktiviere die "CameraON"
            CameraOFF.SetActive(false);
            CameraON.SetActive(true);

            // Aktiviere/deaktiviere Canvas entsprechend
            CanvasOFF.SetActive(false);
            CanvasON.SetActive(true);
        }
        else
        {
            Debug.LogError("Eine oder beide Kameraobjekte sind nicht zugewiesen.");
        }
    }
}
