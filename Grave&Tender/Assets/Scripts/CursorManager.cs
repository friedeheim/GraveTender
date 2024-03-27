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

        // Finde die Zielkamera im Spiel
        targetCamera = Camera.main; // Oder verwenden Sie eine andere Methode, um die Kamera zu finden

        if (targetCamera != null && targetCamera.enabled)
        {
            // Setze den benutzerdefinierten Mauszeiger
            Cursor.SetCursor(customCursor, Vector2.zero, CursorMode.Auto);
            cameraActivated = true;
        }
    }

    void Update()
    {
        // Check if the target camera component is enabled
        if (targetCamera != null && targetCamera.enabled)
        {
            // Check if the cursor needs to be changed
            if (!cameraActivated)
            {
                // Set custom cursor when target camera is enabled
                SetCustomCursor();
            }
        }
        else
        {
            // Reset cursor to default when target camera is disabled
            if (cameraActivated)
            {
                SetDefaultCursor();
            }
        }
    }

    void SetCustomCursor()
    {
        Cursor.SetCursor(customCursor, Vector2.zero, CursorMode.Auto);
        cameraActivated = true;
    }

    void SetDefaultCursor()
    {
        Cursor.SetCursor(defaultCursor, Vector2.zero, CursorMode.Auto);
        cameraActivated = false;
    }
}
