using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    public Texture2D defaultCursor; // Standardmauszeiger
    public Texture2D customCursor; // Benutzerdefinierter Mauszeiger
    public Camera targetCamera; // Zielkamera, bei deren Aktivierung der Mauszeiger geändert wird
    private bool cameraActivated = false; // Zustand der Zielkamera

    void Start()
    {
        // Standardmauszeiger beim Start festlegen
        Cursor.SetCursor(defaultCursor, Vector2.zero, CursorMode.Auto);

        // Überprüfen, ob die Zielkamera existiert und aktiviert ist
        if (targetCamera != null && targetCamera.enabled)
        {
            // Zielkamera ist jetzt aktiv
            Cursor.SetCursor(customCursor, Vector2.zero, CursorMode.Auto);
            cameraActivated = true; // Zustand der Kamera aktualisieren
        }
    }

    void Update()
    {
        // Überprüfen, ob die Zielkamera deaktiviert wurde, nachdem sie einmal aktiviert wurde
        if (cameraActivated && (targetCamera == null || !targetCamera.enabled))
        {
            // Zielkamera ist nicht mehr aktiv
            // Cursor auf den Standardwert zurücksetzen
            Cursor.SetCursor(defaultCursor, Vector2.zero, CursorMode.Auto);
            cameraActivated = false; // Zustand der Kamera aktualisieren
        }
    }
}
