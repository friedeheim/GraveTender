using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableUpdater : MonoBehaviour
{
    public int variable = 5; // Die Variable, die aktualisiert wird
    public GameObject[] objectsToActivate; // Eine Liste von GameObjekten, die aktiviert werden sollen

    private int actionsPerformed = 0; // Anzahl der durchgef�hrten Aktionen

    // Diese Methode wird aufgerufen, um die Variable zu aktualisieren und GameObjekte zu aktivieren/deaktivieren
    public void UpdateVariableAndObjects()
    {
        // �berpr�fen, ob die Variable gr��er als 0 ist, bevor sie verringert wird
        if (variable > 0)
        {
            // Die Variable um 1 verringern
            variable--;

            // Aktiviere und deaktiviere Objekte
            ActivateDeactivateObjects();

            // Inkrementieren der Anzahl der durchgef�hrten Aktionen
            actionsPerformed++;

            // Debug-Log mit dem aktuellen Variablenwert
            Debug.Log("Variable: " + variable);
        }
    }

    // Methode zum Aktivieren und Deaktivieren von Objekten
    private void ActivateDeactivateObjects()
    {
        // Aktiviere das n�chste Objekt in objectsToActivate und deaktiviere alle Objekte in objectsToDeactivate
        for (int i = 0; i < objectsToActivate.Length; i++)
        {
            objectsToActivate[i].SetActive(i == actionsPerformed % objectsToActivate.Length);
        }
    }
}
