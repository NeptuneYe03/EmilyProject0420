using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using TMPro;

public class PlusMinusController : MonoBehaviour
{
    public TextMeshProUGUI numberText; // ��ʾ���ֵ� TextMeshProUGUI ���

    // �������ֵķ���
    public void DecreaseNumber()
    {
        if (numberText != null)
        {
            int currentNumber = int.Parse(numberText.text);
            currentNumber--;
            numberText.text = currentNumber.ToString();
        }
    }

    // �������ֵķ���
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
