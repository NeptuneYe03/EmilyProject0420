using UnityEngine;

public class ActivateCanvasOnKeyPress : MonoBehaviour
{
    public GameObject[] canvases; // �洢Ҫ����� Canvas ������
    public KeyCode[] activationKeys; // �洢ÿ�� Canvas ��Ӧ�ļ����

    private bool[] canvasActiveStates; // ���ڸ��� Canvas �ļ���״̬

    void Start()
    {
        // ��ʼ�� Canvas �ļ���״̬����
        canvasActiveStates = new bool[canvases.Length];
        for (int i = 0; i < canvases.Length; i++)
        {
            canvasActiveStates[i] = false;
            canvases[i].SetActive(false); // �������� Canvas
        }
    }

    void Update()
    {
        // ����ÿ�� Canvas
        for (int i = 0; i < canvases.Length; i++)
        {
            // ����Ƿ����˶�Ӧ�ļ����
            if (Input.GetKeyDown(activationKeys[i]))
            {
                canvasActiveStates[i] = !canvasActiveStates[i]; // �л�����״̬
                canvases[i].SetActive(canvasActiveStates[i]); // ���� Canvas �ļ���״̬
            }
        }

        // �����κ� Canvas ����ʱ��ͣ������
        bool anyCanvasActive = false;
        foreach (bool isActive in canvasActiveStates)
        {
            if (isActive)
            {
                anyCanvasActive = true;
                break;
            }
        }

        if (anyCanvasActive)
        {
            Cursor.lockState = CursorLockMode.None; // �������
            Cursor.visible = true; // ��ʾ���
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked; // �������
            Cursor.visible = false; // �������
        }
    }
}
