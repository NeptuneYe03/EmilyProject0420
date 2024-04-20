using UnityEngine;
using UnityEngine.UI;

public class ShowCanvasOnButtonClick : MonoBehaviour
{
    public GameObject canvasToShow; // Ҫ��ʾ��Canvas����
    public Button button; // ���ð�ť����

    void Start()
    {
        // ��ȡ��ť���
        if (button == null)
        {
            button = GetComponent<Button>();
        }

        // ��Ӱ�ť����¼�������
        if (button != null)
        {
            button.onClick.AddListener(OnButtonClick);
        }
    }

    // ��ť����¼�������
    void OnButtonClick()
    {
        // ��ʾҪ��ʾ��Canvas����
        if (canvasToShow != null)
        {
            canvasToShow.SetActive(true);
        }
    }
}
