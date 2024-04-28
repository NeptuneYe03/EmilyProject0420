using UnityEngine;
using UnityEngine.UI;

public class ChangeImageOnClick : MonoBehaviour
{
    // ��������ͼ�񣬷ֱ��ʾ��ť����״̬�͵��״̬��ͼ��
    public Sprite normalImage;
    public Sprite clickedImage;

    // ���ð�ť�� Image ���
    private Image buttonImage;

    void Start()
    {
        // ��ȡ��ť�� Image ���
        buttonImage = GetComponent<Image>();
    }

    // ����ť�����ʱ���õķ���
    public void OnButtonClick()
    {
        // ��鵱ǰ��ťͼ���Ƿ�Ϊ����״̬��ͼ��
        if (buttonImage.sprite == normalImage)
        {
            // ����ǣ�����ťͼ�����Ϊ���״̬��ͼ��
            buttonImage.sprite = clickedImage;
        }
        else
        {
            // ������ǣ�����ťͼ�����Ϊ����״̬��ͼ��
            buttonImage.sprite = normalImage;
        }
    }
}
