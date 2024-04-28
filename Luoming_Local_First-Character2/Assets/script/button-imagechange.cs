using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChangeButtonImageOnClick : MonoBehaviour
{
    public Button button; // ���ð�ť���
    public Sprite newImage; // �µİ�ťͼ��

    void Start()
    {
        // ��� EventTrigger ���
        EventTrigger trigger = button.gameObject.AddComponent<EventTrigger>();

        // ����һ���¼�
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerDown;
        entry.callback.AddListener((eventData) => { ChangeImage(); });

        // ����¼��� EventTrigger ���
        trigger.triggers.Add(entry);
    }

    void ChangeImage()
    {
        // ����ť��ͼ������Ϊ�µ�ͼ��
        button.image.sprite = newImage;
    }
}
