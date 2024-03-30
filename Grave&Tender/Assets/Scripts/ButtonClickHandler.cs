using UnityEngine;
using UnityEngine.UI;

public class ButtonClickHandler : MonoBehaviour
{
    public Button button;
    public CameraController cameraController;

    private void Start()
    {
        // Fügen Sie einen Listener für den Button-Klick hinzu
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        // Bewegen Sie die Kamera zur neuen Position und Rotation, wenn der Button geklickt wird
        cameraController.MoveCameraToNewPosition();
    }
}
