using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Text textToShow;

    // Wird aufgerufen, wenn die Maus �ber den Button schwebt
    public void OnPointerEnter(PointerEventData eventData)
    {
        // Text sichtbar machen
        textToShow.gameObject.SetActive(true);
    }

    // Wird aufgerufen, wenn die Maus den Button verl�sst
    public void OnPointerExit(PointerEventData eventData)
    {
        // Text ausblenden
        textToShow.gameObject.SetActive(false);
    }
}
