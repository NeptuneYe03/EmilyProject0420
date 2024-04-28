using UnityEngine;
using UnityEngine.UI;

public class ShowCanvas2OnButtonClick : MonoBehaviour
{
    public GameObject canvas2; // 将 Canvas2 拖拽到这个变量中
    public Button button; // 将 Canvas6 中的按钮拖拽到这个变量中
    private bool isCanvas2Visible = false; // 标记 Canvas2 是否可见

    void Start()
    {
        // 添加按钮点击事件监听器，当按钮被点击时调用 ToggleCanvas2 方法
        button.onClick.AddListener(ToggleCanvas2);
        // 初始时隐藏 Canvas2
        canvas2.SetActive(false);
    }

    void ToggleCanvas2()
    {
        // 切换 Canvas2 的可见状态
        isCanvas2Visible = !isCanvas2Visible;
        canvas2.SetActive(isCanvas2Visible);
    }
}
