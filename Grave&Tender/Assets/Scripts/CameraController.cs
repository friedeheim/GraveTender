using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform newCameraTransform;

    public void MoveCameraToNewPosition()
    {
        if (newCameraTransform != null)
        {
            // Setzt die Position und Rotation der Kamera auf die neue Position und Rotation
            Camera.main.transform.position = newCameraTransform.position;
            Camera.main.transform.rotation = newCameraTransform.rotation;
        }
        else
        {
            Debug.LogWarning("Die neue Kamera-Transform ist nicht zugewiesen!");
        }
    }
}
