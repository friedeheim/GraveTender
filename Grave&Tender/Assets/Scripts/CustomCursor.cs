using UnityEngine;

public class CustomCursor : MonoBehaviour
{
    public Texture2D cursorTexture; // Das benutzerdefinierte Cursor-Bild
    public Vector2 hotSpot = new Vector2(16, 16); // Der Hotspot des Cursors (x, y)

    void Start()
    {
        // Setzen Sie den benutzerdefinierten Cursor mit dem Hotspot
        Cursor.SetCursor(cursorTexture, hotSpot, CursorMode.Auto);
    }
}
