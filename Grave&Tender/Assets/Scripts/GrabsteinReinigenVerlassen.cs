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
        // �berpr�fen, ob das Particle-System aktiviert ist und die Szene�nderung noch nicht gestartet wurde
        if (gameObject.activeSelf && !sceneChangeStarted)
        {
            sceneChangeStarted = true;
            Invoke("ChangeScene", 5f); // Wechseln der Szene nach 5 Sekunden
        }
    }

    void ChangeScene()
    {
        // �berpr�fen, ob die Kameraobjekte g�ltig sind
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
