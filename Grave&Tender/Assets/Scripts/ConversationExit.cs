using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DialogueEditor;

public class ConversationExit : MonoBehaviour
{
    [SerializeField] private NPCConversation myConversation;
    [SerializeField] private NPCConversation alternativeConversation; // Der alternative Dialog, der gestartet wird, wenn die Variable 0 ist
    private bool conversationStarted = false;
    public VariableUpdater variableUpdater; // Referenz auf das VariableUpdater-Skript

    public Animator transition;
    public float transitionTime = 1f;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && !conversationStarted)
        {
            // Starte den Dialog nur, wenn er nicht bereits gestartet wurde
            conversationStarted = true;
            ConversationManager.Instance.StartConversation(myConversation);

            // �berpr�fen, ob die Variable in VariableUpdater auf 0 ist
            if (variableUpdater.variable == 0)
            {
                // Starte einen anderen Dialog
                ConversationManager.Instance.StartConversation(alternativeConversation); // Hier kann ein anderer Dialog gestartet werden

                // Warte f�nf Sekunden, bevor die n�chste Szene geladen wird
                Invoke("LoadNextScene", 5f);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Setze den Zustand zur�ck, wenn der Spieler den Collider verl�sst
            conversationStarted = false;
        }
    }

    void LoadNextScene()
    {
        // Lade die n�chste Szene im Szenen-Manager
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex){
        transition.SetTrigger("Start");
        
        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
