using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraktionenAufgebraucht : MonoBehaviour
{
    public VariableUpdater variableUpdater; // Referenz auf das Skript VariableUpdater
    public GameObject[] objectsToDeactivate; // Eine Liste von GameObjekten, die deaktiviert werden sollen

    void Update()
    {
        // Zugriff auf die Variable variable aus dem Skript VariableUpdater
        int value = variableUpdater.variable;
        Debug.Log("Value of variable in VariableUpdater script: " + value);

        // Überprüfe, ob die Variable 0 ist
        if (value == 0)
        {
            // Deaktiviere alle Objekte in der Liste
            foreach (GameObject obj in objectsToDeactivate)
            {
                obj.SetActive(false);
            }
        }
    }
}
