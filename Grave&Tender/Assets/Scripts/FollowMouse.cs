using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    // Offset-Wert für die z-Richtung
    public float zOffset = 1f;

    void Update()
    {
        // Erhalte die aktuelle Position der Maus im Bildschirmkoordinatensystem
        Vector3 mousePosition = Input.mousePosition;

        // Setze die z-Koordinate auf eine festgelegte Distanz vom Kameraobjekt und füge den Offset hinzu
        mousePosition.z = 10f - zOffset;

        // Konvertiere die Bildschirmkoordinaten der Maus in Weltkoordinaten
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // Setze die y-Koordinate auf eine feste Höhe, um sich nicht zu bewegen
        worldMousePosition.y = transform.position.y;

        // Aktualisiere die Position des Objekts, um der Position der Maus zu folgen
        transform.position = worldMousePosition;
    }
}
