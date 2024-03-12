using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementAnimation : MonoBehaviour
{
    private Animator animator;
    private float currentRotation = 0f; // Variable zur Speicherung des aktuellen Drehwinkels

    void Start()
    {
        // Animator-Komponente des Game Objects abrufen
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Überprüfen, ob die "D" oder "Rechts-Pfeiltaste" gedrückt wird
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            // Rotation auf 90 Grad setzen, wenn die aktuelle Rotation nicht bereits 90 Grad ist
            if (currentRotation != 90f)
            {
                transform.rotation = Quaternion.Euler(0, 90, 0);
                currentRotation = 90f;
            }
            // Walking-Animation abspielen
            animator.Play("walking");
        }

        // Überprüfen, ob die "A" oder "Links-Pfeiltaste" gedrückt wird
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // Rotation auf -90 Grad setzen, wenn die aktuelle Rotation nicht bereits -90 Grad ist
            if (currentRotation != -90f)
            {
                transform.rotation = Quaternion.Euler(0, -90, 0);
                currentRotation = -90f;
            }
            // Walking-Animation abspielen
            animator.Play("walking");
        }

        // Überprüfen, ob die "W", "Oben-Pfeiltaste" oder "Numpad 8" gedrückt wird
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Keypad8))
        {
            // Bewegung in Vorwärtsrichtung relativ zur lokalen Orientierung des Objekts
            transform.Translate(transform.forward * Time.deltaTime);
            // Walking-Animation abspielen
            animator.Play("walking");
        }

        // Überprüfen, ob die "S", "Unten-Pfeiltaste" oder "Numpad 2" gedrückt wird
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            // Bewegung in Rückwärtsrichtung relativ zur lokalen Orientierung des Objekts
            transform.Translate(-transform.forward * Time.deltaTime);
            // Walking-Animation abspielen
            animator.Play("walking");
        }
    }
}
