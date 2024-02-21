using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giessen : MonoBehaviour
{
    public GameObject objectToShow;

    void OnParticleCollision(GameObject other)
    {

        Debug.Log("Particle collision detected!");

        // Überprüfen Sie, ob das getroffene Objekt das ist, das wir anzeigen möchten
        if (other == objectToShow)
        {
            Debug.Log("Object to show was hit by particle!");

            // Machen Sie das Objekt sichtbar
            objectToShow.SetActive(true);
        }


        // Überprüfen Sie, ob das getroffene Objekt das ist, das wir anzeigen möchten
        if (other == objectToShow)
        {
            // Machen Sie das Objekt sichtbar
            objectToShow.SetActive(true);
        }
    }



}
