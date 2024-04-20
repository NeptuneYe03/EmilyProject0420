using UnityEngine;
using UnityEngine.UI;

public class ChangeButtonImageOnClick : MonoBehaviour
{
    public Button button; // ���ð�ť���
    public Sprite newImage; // �µİ�ťͼ��

    void Start()
    {
        // ��Ӱ�ť����¼�������������ť�����ʱ���� ChangeImage ����
        button.onClick.AddListener(ChangeImage);
    }

    void ChangeImage()
    {
        // ����ť��ͼ������Ϊ�µ�ͼ��
        button.image.sprite = newImage;
    }
}
