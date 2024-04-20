using UnityEngine;
using UnityEngine.UI;

public class NumberController : MonoBehaviour
{
    public Text numberText; // ���������ı�
    private int number = 0; // ��ʼ����Ϊ0

    // ����ӺŰ�ťʱ���õķ���
    public void OnAddButtonClicked()
    {
        number++; // ���ּ�1
        UpdateNumberText(); // ���������ı���ʾ
    }

    // ������Ű�ťʱ���õķ���
    public void OnSubtractButtonClicked()
    {
        number--; // ���ּ�1
        UpdateNumberText(); // ���������ı���ʾ
    }

    // ���������ı���ʾ
    private void UpdateNumberText()
    {
        numberText.text = number.ToString(); // ������ת��Ϊ�ַ�������ʾ���ı���
    }

    // Start �����ڶ�������ʱ���ã����ڳ�ʼ��
    void Start()
    {
        // ���Ҳ���ȡ������ť
        Button subtractButton = GameObject.Find("minus").GetComponent<Button>();
        // �󶨼�����ť�ĵ���¼��� OnSubtractButtonClicked ����
        subtractButton.onClick.AddListener(OnSubtractButtonClicked);

        // ���Ҳ���ȡ�ӷ���ť
        Button addButton = GameObject.Find("plus").GetComponent<Button>();
        // �󶨼ӷ���ť�ĵ���¼��� OnAddButtonClicked ����
        addButton.onClick.AddListener(OnAddButtonClicked);

        // ���Ҳ���ȡ�����ı�
        numberText = GameObject.Find("Number Text").GetComponent<Text>();
        // ���������ı���ʾ
        UpdateNumberText();
    }
}
