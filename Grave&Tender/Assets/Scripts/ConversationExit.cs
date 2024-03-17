using UnityEngine;
using UnityEngine.SceneManagement;
using DialogueEditor;

public class ConversationExit : MonoBehaviour
{
    [SerializeField] private NPCConversation myConversation;
    [SerializeField] private NPCConversation alternativeConversation; // Der alternative Dialog, der gestartet wird, wenn die Variable 0 ist
    private bool conversationStarted = false;
    public VariableUpdater variableUpdater; // Referenz auf das VariableUpdater-Skript

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && !conversationStarted)
        {
            // Starte den Dialog nur, wenn er nicht bereits gestartet wurde
            conversationStarted = true;
            ConversationManager.Instance.StartConversation(myConversation);

            // Überprüfen, ob die Variable in VariableUpdater auf 0 ist
            if (variableUpdater.variable == 0)
            {
                // Starte einen anderen Dialog
                ConversationManager.Instance.StartConversation(alternativeConversation); // Hier kann ein anderer Dialog gestartet werden

                // Warte fünf Sekunden, bevor die nächste Szene geladen wird
                Invoke("LoadNextScene", 5f);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Setze den Zustand zurück, wenn der Spieler den Collider verlässt
            conversationStarted = false;
        }
    }

    void LoadNextScene()
    {
        // Lade die nächste Szene im Szenen-Manager
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
