using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class ConversationStarter : MonoBehaviour
{
    [SerializeField] private NPCConversation myConversation;
    private bool conversationStarted = false;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && !conversationStarted)
        {
            // Starte den Dialog nur, wenn er nicht bereits gestartet wurde
            conversationStarted = true;
            ConversationManager.Instance.StartConversation(myConversation);
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
}
