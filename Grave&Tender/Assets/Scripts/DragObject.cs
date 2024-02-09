using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZCoord;

    // Adjust this multiplier to control the strength of movement along the z-axis
    public float zMovementMultiplier = 0.01f;

    // Damping factor to reduce sensitivity of movement
    public float dampingFactor = 0.1f;

    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
    }

    private Vector3 GetMouseAsWorldPoint()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;
        mousePoint.y = Mathf.Clamp(mousePoint.y, Screen.height * 0.1f, Screen.height * 0.9f); // Adjusted range
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        Vector3 newPosition = GetMouseAsWorldPoint() + mOffset;

        // Calculate the amount of z-axis movement based on vertical mouse movement
        float zMovement = (Input.mousePosition.y - (Screen.height * 0.5f)) * zMovementMultiplier;

        // Apply damping factor to reduce sensitivity
        zMovement *= dampingFactor;

        newPosition.y = transform.position.y; // Restricting y movement
        newPosition.z += zMovement; // Add the z-axis movement
        transform.position = newPosition;
    }
}
