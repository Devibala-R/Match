using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private CanvasGroup canvasGroup;
    public static  Vector3 OriginalPosition;
    
    public void Start()
    {
       
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup = GetComponent<CanvasGroup>();
        OriginalPosition = GetComponent<RectTransform>().position;

        Debug.Log("Drag begins");
        canvasGroup.blocksRaycasts = false;
    }
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging");
        transform.position = eventData.position;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("Drag ends");
        canvasGroup.blocksRaycasts = true;
       
    }

  
}
