using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
     public GameObject text;

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "interactable")
        {
            text.SetActive(true);
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.tag == "interactable")
        {
            text.SetActive(false);
        }
    }
}
