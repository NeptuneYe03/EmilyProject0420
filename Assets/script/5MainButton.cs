using UnityEngine;
using UnityEngine.UI;

public class ShowCanvasOnButtonClick : MonoBehaviour
{
    public GameObject canvasToShow; // 要显示的Canvas对象
    public Button button; // 引用按钮对象

    void Start()
    {
        // 获取按钮组件
        if (button == null)
        {
            button = GetComponent<Button>();
        }

        // 添加按钮点击事件监听器
        if (button != null)
        {
            button.onClick.AddListener(OnButtonClick);
        }
    }

    // 按钮点击事件处理函数
    void OnButtonClick()
    {
        // 显示要显示的Canvas对象
        if (canvasToShow != null)
        {
            canvasToShow.SetActive(true);
        }
    }
}
