using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DraggableObject : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public GameObject dragIconPrefab; // 拖拽图标的Prefab
    public Sprite dragIconSprite; // 拖拽时显示的图标

    [HideInInspector]
    public GameObject dragIcon; // 拖拽时动态创建的图标对象

    private RectTransform dragRectTransform;
    private Canvas canvas;
    private bool isDraggable; // 标记是否可以拖拽

    void Start()
    {
        canvas = FindObjectOfType<Canvas>();
        Debug.Log("Canvas found: " + (canvas != null));
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isDraggable = true;
        Debug.Log("OnPointerDown called");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (!isDraggable) return;

        Debug.Log("OnBeginDrag called");
        // 创建拖拽图标
        dragIcon = Instantiate(dragIconPrefab, canvas.transform);
        dragIcon.GetComponent<Image>().sprite = dragIconSprite; // 设置拖拽图标的图片
        dragRectTransform = dragIcon.GetComponent<RectTransform>();
        dragRectTransform.sizeDelta = new Vector2(100, 100); // 调整图标大小
        SetDraggedPosition(eventData);
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (!isDraggable) return;

        Debug.Log("OnDrag called");
        SetDraggedPosition(eventData);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (!isDraggable) return;

        Debug.Log("OnEndDrag called");
        Destroy(dragIcon);
        isDraggable = false;
    }

    private void SetDraggedPosition(PointerEventData eventData)
    {
        Vector2 globalMousePos;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, eventData.position, eventData.pressEventCamera, out globalMousePos))
        {
            dragRectTransform.localPosition = globalMousePos;
            Debug.Log("Drag position set to: " + globalMousePos);
        }
    }
}
