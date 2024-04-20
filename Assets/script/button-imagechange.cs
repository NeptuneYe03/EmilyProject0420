using UnityEngine;
using UnityEngine.UI;

public class ChangeButtonImageOnClick : MonoBehaviour
{
    public Button button; // 引用按钮组件
    public Sprite newImage; // 新的按钮图案

    void Start()
    {
        // 添加按钮点击事件监听器，当按钮被点击时调用 ChangeImage 方法
        button.onClick.AddListener(ChangeImage);
    }

    void ChangeImage()
    {
        // 将按钮的图案设置为新的图案
        button.image.sprite = newImage;
    }
}
