using UnityEngine;
using UnityEngine.UI;
using StarterAssets;
using System.Collections;

public class CanvasController : MonoBehaviour
{
    public GameObject taskButtonCanvas; // 初始Canvas
    public GameObject canvas2; // 第二个Canvas
    public GameObject canvas1; // 第一个游戏Canvas
    public GameObject successCanvas; // 成功Canvas，WinConfetti是其子对象

    public Button goButton; // Canvas2中的GoButton
    public Button successButton; // SuccessCanvas中的SuccessButton

    public GameObject[] boxes; // Canvas1中的6个Box
    public Sprite[] iconSprites; // 对应的6个IconImage
    //public GameObject particleEffectPrefab; // 粒子效果预制体，不再需要单独管理

    private FirstPersonController playerController; // 引用第一人称控制器脚本
    private bool isCursorLocked = true;

    private void Start()
    {
        // 初始化设置
        ShowOnlyTaskButtonCanvas();

        // 获取第一人称控制器脚本
        playerController = FindObjectOfType<FirstPersonController>();

        // 添加按钮点击事件
        goButton.onClick.AddListener(OnGoButtonClicked);
        successButton.onClick.AddListener(OnSuccessButtonClicked);
    }

    private void Update()
    {
        // 检查Canvas1中的所有Box是否都被填满
        if (canvas1.activeSelf && AreAllBoxesFilled())
        {
            ShowOnlySuccessCanvas();
        }

        // 检查是否按下Q键
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ShowTaskButtonAndCanvas2();
        }
    }

    public void ShowOnlyTaskButtonCanvas()
    {
        taskButtonCanvas.SetActive(true);
        canvas2.SetActive(false);
        canvas1.SetActive(false);
        successCanvas.SetActive(false);

        LockCursor(true); // 锁定鼠标控制视角
    }

    public void ShowTaskButtonAndCanvas2()
    {
        taskButtonCanvas.SetActive(true);
        canvas2.SetActive(true);
        canvas1.SetActive(false);
        successCanvas.SetActive(false);

        LockCursor(false); // 解锁鼠标，用于UI交互
    }

    public void ShowOnlyCanvas1()
    {
        taskButtonCanvas.SetActive(false);
        canvas2.SetActive(false);
        canvas1.SetActive(true);
        successCanvas.SetActive(false);

        LockCursor(true); // 锁定鼠标控制视角
    }

    public void ShowOnlySuccessCanvas()
    {
        taskButtonCanvas.SetActive(false);
        canvas2.SetActive(false);
        canvas1.SetActive(false);
        successCanvas.SetActive(true); // 显示SuccessCanvas和它的子对象，包括WinConfetti

        LockCursor(false); // 解锁鼠标，用于UI交互
    }

    public void OnGoButtonClicked()
    {
        ShowOnlyCanvas1();
    }

    public void OnSuccessButtonClicked()
    {
        ShowOnlyTaskButtonCanvas();
    }

    private bool AreAllBoxesFilled()
    {
        foreach (GameObject box in boxes)
        {
            if (box.transform.childCount == 0)
            {
                return false;
            }
        }
        return true;
    }

    private void LockCursor(bool lockCursor)
    {
        isCursorLocked = lockCursor;

        if (isCursorLocked)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            if (playerController != null)
            {
                playerController.enabled = true; // 启用人物视角控制
            }
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            if (playerController != null)
            {
                playerController.enabled = false; // 禁用人物视角控制
            }
        }
    }
}
