using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    private Quaternion initialRotation;

    void Start()
    {
        // Speichern der Ausgangsrotation des Objekts
        initialRotation = transform.rotation;
    }

    void Update()
    {
        // Wenn die Maustaste gedrückt wird
        if (Input.GetMouseButtonDown(0))
        {
            // Rotiere das Objekt um 15 Grad nach links
            transform.Rotate(Vector3.right, +15f);
        }

        // Wenn die Maustaste losgelassen wird
        if (Input.GetMouseButtonUp(0))
        {
            // Setze das Objekt zurück zur Ausgangsrotation
            transform.rotation = initialRotation;
        }
    }
}
