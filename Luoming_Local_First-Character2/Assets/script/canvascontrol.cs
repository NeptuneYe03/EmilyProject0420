using UnityEngine;

public class ActivateCanvasOnKeyPress : MonoBehaviour
{
    public GameObject[] canvases; // 存储要激活的 Canvas 的数组
    public KeyCode[] activationKeys; // 存储每个 Canvas 对应的激活按键

    private bool[] canvasActiveStates; // 用于跟踪 Canvas 的激活状态

    void Start()
    {
        // 初始化 Canvas 的激活状态数组
        canvasActiveStates = new bool[canvases.Length];
        for (int i = 0; i < canvases.Length; i++)
        {
            canvasActiveStates[i] = false;
            canvases[i].SetActive(false); // 隐藏所有 Canvas
        }
    }

    void Update()
    {
        // 遍历每个 Canvas
        for (int i = 0; i < canvases.Length; i++)
        {
            // 检测是否按下了对应的激活按键
            if (Input.GetKeyDown(activationKeys[i]))
            {
                canvasActiveStates[i] = !canvasActiveStates[i]; // 切换激活状态
                canvases[i].SetActive(canvasActiveStates[i]); // 设置 Canvas 的激活状态
            }
        }

        // 当有任何 Canvas 激活时暂停鼠标控制
        bool anyCanvasActive = false;
        foreach (bool isActive in canvasActiveStates)
        {
            if (isActive)
            {
                anyCanvasActive = true;
                break;
            }
        }

        if (anyCanvasActive)
        {
            Cursor.lockState = CursorLockMode.None; // 解锁鼠标
            Cursor.visible = true; // 显示鼠标
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked; // 锁定鼠标
            Cursor.visible = false; // 隐藏鼠标
        }
    }
}
