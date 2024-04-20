using UnityEngine;

public class ShowPopupOnApproach : MonoBehaviour
{
    public Transform player; // 玩家角色的Transform
    public GameObject popupUI; // 弹窗UI元素

    public float popupDistanceThreshold = 2f; // 触发弹窗的距离阈值

    private void Update()
    {
        if (player == null || popupUI == null) return;

        // 计算玩家与物体之间的距离
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // 如果距离小于阈值，则显示弹窗；否则隐藏弹窗
        if (distanceToPlayer < popupDistanceThreshold)
        {
            popupUI.SetActive(true);

            // 将弹窗的位置设置为物体的世界空间坐标
            popupUI.transform.position = transform.position + Vector3.up * 2; // 这里的 2 是弹窗的高度偏移
        }
        else
        {
            popupUI.SetActive(false);
        }
    }
}
