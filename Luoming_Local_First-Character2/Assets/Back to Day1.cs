using UnityEngine;
using UnityEngine.UI;

public class SwitchCanvasOnClick : MonoBehaviour
{
    public GameObject canvas1; // ��Ҫ���ص� Canvas1
    public GameObject canvas2; // ��Ҫ��ʾ�� Canvas2
    public Button button; // ��ť���

    void Start()
    {
        // ��Ӱ�ť����¼�������
        button.onClick.AddListener(SwitchCanvas);
    }

    void SwitchCanvas()
    {
        // ���� Canvas1
        if (canvas1 != null)
        {
            canvas1.SetActive(false);
        }

        // ��ʾ Canvas2
        if (canvas2 != null)
        {
            canvas2.SetActive(true);
        }
    }
}
