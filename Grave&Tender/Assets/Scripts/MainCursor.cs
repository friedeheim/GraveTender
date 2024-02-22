using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCursor : MonoBehaviour
{
    public Texture2D cursorTexture; // Das Bild für den benutzerdefinierten Cursor

    void Start()
    {
        // Setzen Sie den Cursor auf den benutzerdefinierten Cursor
        Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
    }
}
