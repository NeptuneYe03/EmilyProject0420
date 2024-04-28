using UnityEngine;

public class ShowCanvasOnKeyPress : MonoBehaviour
{
    public GameObject canvas; // ����Canvas����
    public KeyCode key; // �������ֵİ���

    void Update()
    {
        // ����Ƿ���ָ������
        if (Input.GetKeyDown(key))
        {
            // �л�Canvas������״̬
            canvas.SetActive(!canvas.activeSelf);
        }
    }
}
