using UnityEngine;
using UnityEngine.UI;

public class SwitchCanvas : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject canvas2;
    public Button buttonInCanvas2;

    void Start()
    {
        // 添加按钮点击事件监听器，当按钮被点击时调用 SwitchCanvas 方法
        buttonInCanvas2.onClick.AddListener(SwitchCanvasState);
    }

    void SwitchCanvasState()
    {
        // 切换 Canvas1 和 Canvas2 的可见状态
        canvas1.SetActive(true);
        canvas2.SetActive(false);
    }
}
