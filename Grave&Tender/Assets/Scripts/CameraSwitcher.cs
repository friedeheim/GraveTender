using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera[] cameras; // Array mit allen Kameras, die geschaltet werden sollen

    // Methode zum Aktivieren einer bestimmten Kamera und Deaktivieren aller anderen
    public void SwitchCamera(Camera activeCamera)
    {
        foreach (Camera camera in cameras)
        {
            if (camera == activeCamera)
            {
                // Aktiviere die angegebene Kamera
                camera.enabled = true;
            }
            else
            {
                // Deaktiviere alle anderen Kameras
                camera.enabled = false;
            }
        }
    }
}
