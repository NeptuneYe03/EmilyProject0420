using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropZone : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        DraggableObject draggable = eventData.pointerDrag.GetComponent<DraggableObject>();
        if (draggable != null && draggable.dragIcon != null)
        {
            draggable.dragIcon.transform.SetParent(transform);
            draggable.dragIcon.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
        }
    }
}
