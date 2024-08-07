using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DraggableObject : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public GameObject dragIconPrefab; // ��קͼ���Prefab
    public Sprite dragIconSprite; // ��קʱ��ʾ��ͼ��

    [HideInInspector]
    public GameObject dragIcon; // ��קʱ��̬������ͼ�����

    private RectTransform dragRectTransform;
    private Canvas canvas;
    private bool isDraggable; // ����Ƿ������ק

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
        // ������קͼ��
        dragIcon = Instantiate(dragIconPrefab, canvas.transform);
        dragIcon.GetComponent<Image>().sprite = dragIconSprite; // ������קͼ���ͼƬ
        dragRectTransform = dragIcon.GetComponent<RectTransform>();
        dragRectTransform.sizeDelta = new Vector2(100, 100); // ����ͼ���С
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
