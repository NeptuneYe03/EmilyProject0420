using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    public GameObject taskButtonCanvas; // 初始Canvas
    public GameObject canvas2; // 第二个Canvas
    public GameObject canvas1; // 第一个游戏Canvas
    public GameObject successCanvas; // 成功Canvas

    public Button taskButton; // TaskButtonCanvas中的TaskButton
    public Button goButton; // Canvas2中的GoButton
    public Button successButton; // SuccessCanvas中的SuccessButton

    public GameObject[] boxes; // Canvas1中的6个Box
    public Sprite[] iconSprites; // 对应的6个IconImage
    public GameObject particleEffectPrefab; // 粒子效果预制体

    private void Start()
    {
        // 初始化设置
        ShowOnlyTaskButtonCanvas();

        // 添加按钮点击事件
        taskButton.onClick.AddListener(OnTaskButtonClicked);
        goButton.onClick.AddListener(OnGoButtonClicked);
        successButton.onClick.AddListener(OnSuccessButtonClicked);
    }

    public void ShowOnlyTaskButtonCanvas()
    {
        taskButtonCanvas.SetActive(true);
        canvas2.SetActive(false);
        canvas1.SetActive(false);
        successCanvas.SetActive(false);
    }

    public void ShowTaskButtonAndCanvas2()
    {
        taskButtonCanvas.SetActive(true);
        canvas2.SetActive(true);
        canvas1.SetActive(false);
        successCanvas.SetActive(false);
    }

    public void ShowOnlyCanvas1()
    {
        taskButtonCanvas.SetActive(false);
        canvas2.SetActive(false);
        canvas1.SetActive(true);
        successCanvas.SetActive(false);
    }

    public void ShowOnlySuccessCanvas()
    {
        taskButtonCanvas.SetActive(false);
        canvas2.SetActive(false);
        canvas1.SetActive(false);
        successCanvas.SetActive(true);
    }

    public void OnTaskButtonClicked()
    {
        ShowTaskButtonAndCanvas2();
    }

    public void OnGoButtonClicked()
    {
        ShowOnlyCanvas1();
    }

    public void OnSuccessButtonClicked()
    {
        ShowOnlyTaskButtonCanvas();
    }

    private void Update()
    {
        // 检查Canvas1中的所有Box是否都被填满
        if (canvas1.activeSelf && AreAllBoxesFilled())
        {
            ShowOnlySuccessCanvas();
        }
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

    // 将图标添加到指定的Box中并播放粒子效果
    public void AddIconToBox(int boxIndex)
    {
        if (boxIndex >= 0 && boxIndex < boxes.Length)
        {
            // 添加IconImage
            Image boxImage = boxes[boxIndex].GetComponent<Image>();
            if (boxImage != null && boxIndex < iconSprites.Length)
            {
                boxImage.sprite = iconSprites[boxIndex];
            }

            // 创建并播放粒子效果
            GameObject particleEffect = Instantiate(particleEffectPrefab, boxes[boxIndex].transform.position, Quaternion.identity);
            particleEffect.transform.SetParent(boxes[boxIndex].transform, false);
            Destroy(particleEffect, 2f); // 确保粒子效果在一段时间后被销毁
        }
    }
}
