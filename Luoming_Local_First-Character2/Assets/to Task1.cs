using UnityEngine;
using UnityEngine.UI;

public class SwitchCanvas : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject canvas2;
    public Button buttonInCanvas2;

    void Start()
    {
        // ��Ӱ�ť����¼�������������ť�����ʱ���� SwitchCanvas ����
        buttonInCanvas2.onClick.AddListener(SwitchCanvasState);
    }

    void SwitchCanvasState()
    {
        // �л� Canvas1 �� Canvas2 �Ŀɼ�״̬
        canvas1.SetActive(true);
        canvas2.SetActive(false);
    }
}
