using UnityEngine;
using UnityEngine.UI;

public class ScrollViewController : MonoBehaviour
{
    public ScrollRect scrollRect; // ���� ScrollView ���

    void Start()
    {
        // ��ˮƽ����������������Ϊ null
        scrollRect.horizontalScrollbar = null;
    }
}
