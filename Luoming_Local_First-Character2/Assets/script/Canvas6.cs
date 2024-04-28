using UnityEngine;

public class ShowCanvasOnKeyPress : MonoBehaviour
{
    public GameObject canvas; // 引用Canvas对象
    public KeyCode key; // 触发显现的按键

    void Update()
    {
        // 检查是否按下指定按键
        if (Input.GetKeyDown(key))
        {
            // 切换Canvas的显现状态
            canvas.SetActive(!canvas.activeSelf);
        }
    }
}
