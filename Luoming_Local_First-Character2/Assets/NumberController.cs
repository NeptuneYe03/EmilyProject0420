using UnityEngine;
using UnityEngine.UI;

public class NumberController : MonoBehaviour
{
    public Text numberText; // 引用数字文本
    private int number = 0; // 初始数字为0

    // 点击加号按钮时调用的方法
    public void OnAddButtonClicked()
    {
        number++; // 数字加1
        UpdateNumberText(); // 更新数字文本显示
    }

    // 点击减号按钮时调用的方法
    public void OnSubtractButtonClicked()
    {
        number--; // 数字减1
        UpdateNumberText(); // 更新数字文本显示
    }

    // 更新数字文本显示
    private void UpdateNumberText()
    {
        numberText.text = number.ToString(); // 将数字转换为字符串并显示在文本中
    }

    // Start 方法在对象启用时调用，用于初始化
    void Start()
    {
        // 查找并获取减法按钮
        Button subtractButton = GameObject.Find("minus").GetComponent<Button>();
        // 绑定减法按钮的点击事件到 OnSubtractButtonClicked 方法
        subtractButton.onClick.AddListener(OnSubtractButtonClicked);

        // 查找并获取加法按钮
        Button addButton = GameObject.Find("plus").GetComponent<Button>();
        // 绑定加法按钮的点击事件到 OnAddButtonClicked 方法
        addButton.onClick.AddListener(OnAddButtonClicked);

        // 查找并获取数字文本
        numberText = GameObject.Find("Number Text").GetComponent<Text>();
        // 更新数字文本显示
        UpdateNumberText();
    }
}
