using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giessen : MonoBehaviour
{
    public List<ActivationPair> activationPairs = new List<ActivationPair>();

    private void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag("Waessern"))
        {
            // Iterieren Sie durch die Liste der Aktivierungspaare
            foreach (ActivationPair pair in activationPairs)
            {
                // Überprüfen Sie, ob das getroffene Objekt eines der Paare ist
                if (pair.targetObject == other.gameObject)
                {
                    // Starten Sie eine Verzögerung für das Aktivieren und Löschen dieses Paars
                    StartCoroutine(ActivateAndDeleteDelayed(pair));
                    break; // Beenden Sie die Schleife, sobald ein Paar gefunden wurde
                }
            }
        }
    }

    // Aktivieren und Löschen der GameObjects mit individueller Verzögerung
    private IEnumerator ActivateAndDeleteDelayed(ActivationPair pair)
    {
        // Verzögern Sie das Aktivieren und Löschen dieses Objektpaars
        yield return new WaitForSeconds(1f);

        // Aktivieren Sie das GameObject
        pair.objectToActivate.SetActive(true);

        // Löschen Sie das GameObject
        Destroy(pair.objectToDelete);
    }
}

// Eine Klasse zur Repräsentation eines Aktivierungspaares
[System.Serializable]
public class ActivationPair
{
    public GameObject targetObject; // Das getroffene Objekt
    public GameObject objectToActivate; // Das Objekt, das aktiviert werden soll
    public GameObject objectToDelete; // Das Objekt, das gelöscht werden soll
}
