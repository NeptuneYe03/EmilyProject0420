using UnityEngine;
using UnityEngine.UI;

public class SwitchCanvasOnClick : MonoBehaviour
{
    public GameObject canvas1; // 需要隐藏的 Canvas1
    public GameObject canvas2; // 需要显示的 Canvas2
    public Button button; // 按钮组件

    void Start()
    {
        // 添加按钮点击事件监听器
        button.onClick.AddListener(SwitchCanvas);
    }

    void SwitchCanvas()
    {
        // 隐藏 Canvas1
        if (canvas1 != null)
        {
            canvas1.SetActive(false);
        }

        // 显示 Canvas2
        if (canvas2 != null)
        {
            canvas2.SetActive(true);
        }
    }
}
