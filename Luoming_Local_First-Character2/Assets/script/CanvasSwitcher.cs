using UnityEngine;
using UnityEngine.UI;

public class CanvasSwitcher : MonoBehaviour
{
    public Canvas canvas1;
    public Canvas canvas2;
    public Button switchButton;

    void Start()
    {
        // ȷ������ʱCanvas2�ɼ���Canvas1����
        canvas1.gameObject.SetActive(false);
        canvas2.gameObject.SetActive(true);

        // ��Ӱ�ť����¼�������
        switchButton.onClick.AddListener(SwitchCanvas);
    }

    public void SwitchCanvas() // ȷ��������public
    {
        Debug.Log("SwitchCanvas method called"); // ������־
        // ����Canvas2����ʾCanvas1
        canvas2.gameObject.SetActive(false);
        canvas1.gameObject.SetActive(true);
        Debug.Log("Canvas2 disabled, Canvas1 enabled"); // ������־

        Cursor.visible = true; // ǿ����ʾ���
    }
}
