using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CursorManager : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Texture2D cursorNormal, cursorHighlight;
    private Vector2 normalHotspot, highlightHotspot;

    public void OnPointerEnter(PointerEventData eventData)
    {   
        Cursor.SetCursor(cursorHighlight, highlightHotspot, CursorMode.Auto);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Cursor.SetCursor(cursorNormal, normalHotspot, CursorMode.Auto);
    }
}
