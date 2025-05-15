using UnityEngine;
using UnityEngine.EventSystems;

public class ToggleEmoteButtonsOnTap : MonoBehaviour, IPointerDownHandler
{
    public GameObject emoteButtonCanvas;
    private bool isVisible = false;

    void Start()
    {
        if (emoteButtonCanvas != null)
            emoteButtonCanvas.SetActive(false);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isVisible = !isVisible;
        emoteButtonCanvas.SetActive(isVisible);
    }
}
