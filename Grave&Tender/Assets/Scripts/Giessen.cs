using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giessen : MonoBehaviour
{
    public GameObject objectToActivate;
    public GameObject objectToDelete;

    private void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag("Waessern"))
        {
            // Rufen Sie die Methode ActivateAndDelete mit einer Verzögerung von 2 Sekunden auf
            Invoke("ActivateAndDelete", 1f);
        }
    }

    private void ActivateAndDelete()
    {
        // Aktiviere das GameObject objectToActivate
        objectToActivate.SetActive(true);

        // Löschen Sie das GameObject objectToDelete
        Destroy(objectToDelete);
    }
}
