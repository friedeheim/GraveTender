using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class HelpButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TextMeshProUGUI textToShow; // Der TextMeshPro-Text, der angezeigt werden soll

    void Start()
    {
        if (textToShow != null)
        {
            textToShow.gameObject.SetActive(false); // Deaktivieren Sie den Text am Anfang
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (textToShow != null)
        {
            textToShow.gameObject.SetActive(true); // Text anzeigen, wenn Maus über den Button schwebt
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (textToShow != null)
        {
            textToShow.gameObject.SetActive(false); // Text ausblenden, wenn die Maus den Button verlässt
        }
    }
}
