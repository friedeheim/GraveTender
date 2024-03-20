using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementAnimation : MonoBehaviour
{
    private Animator animator;
    public float moveSpeed = 3f; // Geschwindigkeit des Charakters

    void Start()
    {
        // Animator-Komponente des Game Objects abrufen
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Bewegungsrichtung des Charakters
        float horizontalInput = -Input.GetAxis("Horizontal");
        float verticalInput = -Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // Rotation des Charakters
        if (moveDirection != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(moveDirection);
        }

        // Bewegung des Charakters relativ zur Kamera
        Vector3 move = moveDirection * moveSpeed * Time.deltaTime;
        transform.Translate(move, Space.World);

        // Animation abh�ngig von der Bewegung abspielen
        if (moveDirection.magnitude > 0)
        {
            animator.SetBool("Walking", true);
        }
        else
        {
            animator.SetBool("Walking", false);
        }
    }
}
