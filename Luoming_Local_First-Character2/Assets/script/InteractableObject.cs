using UnityEngine;
using UnityEngine.UI;

public class InteractableObject : MonoBehaviour
{
    public Sprite objectIcon; // 物体对应的图标
    public GameObject targetBox; // Canvas1中目标Box
    public Vector2 iconSize = new Vector2(100, 100); // 图标的尺寸

    private bool isPlayerNearby = false;

    void Update()
    {
        // 检测玩家是否按下G键并且在物体附近
        if (isPlayerNearby && Input.GetKeyDown(KeyCode.G))
        {
            AddIconToBox();
        }
    }

    private void AddIconToBox()
    {
        // 在目标Box上创建一个新的Image组件
        GameObject newIcon = new GameObject("Icon");
        newIcon.transform.SetParent(targetBox.transform, false);

        Image imageComponent = newIcon.AddComponent<Image>();
        imageComponent.sprite = objectIcon;
        imageComponent.rectTransform.sizeDelta = iconSize; // 设置图标大小
        imageComponent.rectTransform.anchoredPosition = Vector2.zero; // 确保图标在Box的中央

        Debug.Log("Icon added to the box");
    }

    private void OnTriggerEnter(Collider other)
    {
        // 检测玩家是否进入物体的触发范围
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = true;
            Debug.Log("Player is nearby");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // 检测玩家是否离开物体的触发范围
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = false;
            Debug.Log("Player left");
        }
    }
}
