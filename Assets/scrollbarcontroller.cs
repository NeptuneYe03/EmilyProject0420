using UnityEngine;
using UnityEngine.UI;

public class ScrollViewController : MonoBehaviour
{
    public ScrollRect scrollRect; // 引用 ScrollView 组件

    void Start()
    {
        // 将水平滚动条的引用设置为 null
        scrollRect.horizontalScrollbar = null;
    }
}
