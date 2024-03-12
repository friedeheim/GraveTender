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
        // �berpr�fen, ob die "D" oder "Rechts-Pfeiltaste" gedr�ckt wird
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

        // �berpr�fen, ob die "A" oder "Links-Pfeiltaste" gedr�ckt wird
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

        // �berpr�fen, ob die "W", "Oben-Pfeiltaste" oder "Numpad 8" gedr�ckt wird
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Keypad8))
        {
            // Bewegung in Vorw�rtsrichtung relativ zur lokalen Orientierung des Objekts
            transform.Translate(transform.forward * Time.deltaTime);
            // Walking-Animation abspielen
            animator.Play("walking");
        }

        // �berpr�fen, ob die "S", "Unten-Pfeiltaste" oder "Numpad 2" gedr�ckt wird
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            // Bewegung in R�ckw�rtsrichtung relativ zur lokalen Orientierung des Objekts
            transform.Translate(-transform.forward * Time.deltaTime);
            // Walking-Animation abspielen
            animator.Play("walking");
        }
    }
}
