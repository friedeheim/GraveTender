using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartWasser : MonoBehaviour
{
    new private ParticleSystem particleSystem;
    private bool isPlaying = false;

    void Start()
    {
        // Holen Sie das Particle System-Komponente
        particleSystem = GetComponent<ParticleSystem>();

        // Stoppen Sie das Partikelsystem, wenn das Spiel beginnt
        particleSystem.Stop();
    }

    void Update()
    {
        // Wenn die Maustaste gedrückt wird und das Partikelsystem nicht abgespielt wird
        if (Input.GetMouseButtonDown(0) && !isPlaying)
        {
            // Starten Sie das Partikelsystem
            particleSystem.Play();
            isPlaying = true; // Setzen Sie den Zustand, dass das Partikelsystem abgespielt wird
        }

        // Wenn die Maustaste losgelassen wird
        if (Input.GetMouseButtonUp(0) && isPlaying)
        {
            // Stoppen Sie das Partikelsystem
            particleSystem.Stop();
            isPlaying = false; // Setzen Sie den Zustand, dass das Partikelsystem nicht mehr abgespielt wird
        }
    }
}
