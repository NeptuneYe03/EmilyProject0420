using UnityEngine;
using UnityEngine.UI;

public class CanvasSwitcher : MonoBehaviour
{
    public Canvas canvas1;
    public Canvas canvas2;
    public Button switchButton;

    void Start()
    {
        // 确保启动时Canvas2可见，Canvas1隐藏
        canvas1.gameObject.SetActive(false);
        canvas2.gameObject.SetActive(true);

        // 添加按钮点击事件监听器
        switchButton.onClick.AddListener(SwitchCanvas);
    }

    public void SwitchCanvas() // 确保方法是public
    {
        Debug.Log("SwitchCanvas method called"); // 调试日志
        // 隐藏Canvas2，显示Canvas1
        canvas2.gameObject.SetActive(false);
        canvas1.gameObject.SetActive(true);
        Debug.Log("Canvas2 disabled, Canvas1 enabled"); // 调试日志

        Cursor.visible = true; // 强制显示光标
    }
}
