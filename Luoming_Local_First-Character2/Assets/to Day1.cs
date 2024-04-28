using UnityEngine;
using UnityEngine.UI;

public class ShowCanvas2OnButtonClick : MonoBehaviour
{
    public GameObject canvas2; // �� Canvas2 ��ק�����������
    public Button button; // �� Canvas6 �еİ�ť��ק�����������
    private bool isCanvas2Visible = false; // ��� Canvas2 �Ƿ�ɼ�

    void Start()
    {
        // ��Ӱ�ť����¼�������������ť�����ʱ���� ToggleCanvas2 ����
        button.onClick.AddListener(ToggleCanvas2);
        // ��ʼʱ���� Canvas2
        canvas2.SetActive(false);
    }

    void ToggleCanvas2()
    {
        // �л� Canvas2 �Ŀɼ�״̬
        isCanvas2Visible = !isCanvas2Visible;
        canvas2.SetActive(isCanvas2Visible);
    }
}
