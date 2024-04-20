using UnityEngine;
using UnityEngine.UI;

public class ChangeImageOnClick : MonoBehaviour
{
    // 定义两个图像，分别表示按钮正常状态和点击状态的图像
    public Sprite normalImage;
    public Sprite clickedImage;

    // 引用按钮的 Image 组件
    private Image buttonImage;

    void Start()
    {
        // 获取按钮的 Image 组件
        buttonImage = GetComponent<Image>();
    }

    // 当按钮被点击时调用的方法
    public void OnButtonClick()
    {
        // 检查当前按钮图像是否为正常状态的图像
        if (buttonImage.sprite == normalImage)
        {
            // 如果是，将按钮图像更改为点击状态的图像
            buttonImage.sprite = clickedImage;
        }
        else
        {
            // 如果不是，将按钮图像更改为正常状态的图像
            buttonImage.sprite = normalImage;
        }
    }
}
