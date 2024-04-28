using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChangeButtonImageOnClick : MonoBehaviour
{
    public Button button; // 引用按钮组件
    public Sprite newImage; // 新的按钮图案

    void Start()
    {
        // 添加 EventTrigger 组件
        EventTrigger trigger = button.gameObject.AddComponent<EventTrigger>();

        // 创建一个事件
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerDown;
        entry.callback.AddListener((eventData) => { ChangeImage(); });

        // 添加事件到 EventTrigger 组件
        trigger.triggers.Add(entry);
    }

    void ChangeImage()
    {
        // 将按钮的图案设置为新的图案
        button.image.sprite = newImage;
    }
}
