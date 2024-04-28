using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using TMPro;

public class PlusMinusController : MonoBehaviour
{
    public TextMeshProUGUI numberText; // 显示数字的 TextMeshProUGUI 组件

    // 减少数字的方法
    public void DecreaseNumber()
    {
        if (numberText != null)
        {
            int currentNumber = int.Parse(numberText.text);
            currentNumber--;
            numberText.text = currentNumber.ToString();
        }
    }

    // 增加数字的方法
    public void IncreaseNumber()
    {
        if (numberText != null)
        {
            int currentNumber = int.Parse(numberText.text);
            currentNumber++;
            numberText.text = currentNumber.ToString();
        }
    }
}
