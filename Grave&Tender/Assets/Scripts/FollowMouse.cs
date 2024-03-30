using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    // Offset-Wert für die z-Richtung
    public float zOffset = 1f;

    // Grenzen für die Bewegung des Objekts
    public float minX = 20.10f;
    public float maxX = 27.36f;
    public float minZ = -3.33f;
    public float maxZ = -0.55f;

    void Update()
    {
        // Erhalte die aktuelle Position der Maus im Bildschirmkoordinatensystem
        Vector3 mousePosition = Input.mousePosition;

        // Setze die z-Koordinate auf eine festgelegte Distanz vom Kameraobjekt und füge den Offset hinzu
        mousePosition.z = 9.5f - zOffset;

        // Konvertiere die Bildschirmkoordinaten der Maus in Weltkoordinaten
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // Begrenze die Position des Objekts innerhalb der festgelegten Grenzen
        float clampedX = Mathf.Clamp(worldMousePosition.x, minX, maxX);
        float clampedZ = Mathf.Clamp(worldMousePosition.z, minZ, maxZ);
        worldMousePosition = new Vector3(clampedX, transform.position.y, clampedZ);

        // Aktualisiere die Position des Objekts, um der Position der Maus zu folgen
        transform.position = worldMousePosition;
    }
}
