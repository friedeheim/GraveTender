using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    public Material[] newMaterials; // Die neuen Materialien, die auf das Objekt angewendet werden sollen
    public GameObject particleSystemObject; // Das Particle-System-Objekt, das aktiviert werden soll
    private bool isMouseDown = false;
    private float mouseDownTime = 0f;
    private float[] changeTimes = { 3f, 6f, 9f }; // Zeitpunkte, zu denen das Material gewechselt werden soll
    private int materialIndex = 0; // Index des aktuellen Materials
    private bool particleSystemActivated = false; // Ob das Particle-System bereits aktiviert wurde
    private bool hasSwiped = false; // Ob der Benutzer über das Objekt gewischt hat

    void Update()
    {
        // Überprüfen, ob die linke Maustaste gedrückt wird
        if (Input.GetMouseButtonDown(0))
        {
            isMouseDown = true;
            mouseDownTime = Time.time;
        }

        // Überprüfen, ob die linke Maustaste losgelassen wird
        if (Input.GetMouseButtonUp(0))
        {
            isMouseDown = false;
            mouseDownTime = 0f;
        }

        // Wenn die linke Maustaste gedrückt wird und die erforderliche Zeit verstrichen ist
        if (isMouseDown && materialIndex < changeTimes.Length && Time.time - mouseDownTime >= changeTimes[materialIndex])
        {
            // Überprüfen, ob die Maus über das Objekt wischt
            RaycastHit hit;
            // Kamera mit dem Namen "Main Camera (Reinigen)" finden
            Camera myCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
            // Ray von der Mausposition in Bezug auf die gefundenen Kamera erstellen
            Ray ray = myCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                // Überprüfen, ob das getroffene Objekt das GameObject ist, zu dem dieses Skript gehört
                if (hit.collider.gameObject == gameObject)
                {
                    hasSwiped = true; // Der Benutzer hat über das Objekt gewischt
                    ChangeMaterial(); // Ändere das Material des Objekts
                }
            }
        }
    }

    void ChangeMaterial()
    {
        // Überprüfen, ob das Objekt ein Renderer-Komponente hat
        Renderer rend = GetComponent<Renderer>();
        if (rend != null)
        {
            // Überprüfen, ob noch Materialien übrig sind
            if (materialIndex < newMaterials.Length)
            {
                rend.material = newMaterials[materialIndex]; // Ändere das Material des Objekts
                materialIndex++;

                // Überprüfen, ob das letzte Material angewendet wurde
                if (materialIndex == newMaterials.Length)
                {
                    // Hier das Material hinzufügen, bei dem das Partikelsystem aktiviert werden soll
                    if (!particleSystemActivated && hasSwiped && rend.material.name == "Stein (Instance)") // Anpassen, um den korrekten Namen des Materials zu verwenden
                    {
                        ActivateParticleSystem(); // Aktiviere das Particle-System
                    }
                }
            }
        }
    }

    void ActivateParticleSystem()
    {
        if (particleSystemObject != null)
        {
            particleSystemObject.SetActive(true); // Aktiviere das Particle-System-Objekt
            particleSystemActivated = true;
        }
    }
}
