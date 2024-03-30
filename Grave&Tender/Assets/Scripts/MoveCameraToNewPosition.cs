using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraToNewPosition : MonoBehaviour
{
    public Transform newCameraTransform;
    // Start is called before the first frame update
    void Start()
    {
        Camera.main.transform.position = newCameraTransform.position;
        Camera.main.transform.rotation = newCameraTransform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
