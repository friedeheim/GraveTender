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
                // �berpr�fen Sie, ob das getroffene Objekt eines der Paare ist
                if (pair.targetObject == other.gameObject)
                {
                    // Starten Sie eine Verz�gerung f�r das Aktivieren und L�schen dieses Paars
                    StartCoroutine(ActivateAndDeleteDelayed(pair));
                    break; // Beenden Sie die Schleife, sobald ein Paar gefunden wurde
                }
            }
        }
    }

    // Aktivieren und L�schen der GameObjects mit individueller Verz�gerung
    private IEnumerator ActivateAndDeleteDelayed(ActivationPair pair)
    {
        // Verz�gern Sie das Aktivieren und L�schen dieses Objektpaars
        yield return new WaitForSeconds(1f);

        // Aktivieren Sie das GameObject
        pair.objectToActivate.SetActive(true);

        // L�schen Sie das GameObject
        Destroy(pair.objectToDelete);
    }
}

// Eine Klasse zur Repr�sentation eines Aktivierungspaares
[System.Serializable]
public class ActivationPair
{
    public GameObject targetObject; // Das getroffene Objekt
    public GameObject objectToActivate; // Das Objekt, das aktiviert werden soll
    public GameObject objectToDelete; // Das Objekt, das gel�scht werden soll
}
