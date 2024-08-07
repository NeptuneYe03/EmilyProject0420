using UnityEngine;
using UnityEngine.UI;

public class InteractableObject : MonoBehaviour
{
    public Sprite objectIcon; // �����Ӧ��ͼ��
    public GameObject targetBox; // Canvas1��Ŀ��Box
    public Vector2 iconSize = new Vector2(100, 100); // ͼ��ĳߴ�

    private bool isPlayerNearby = false;

    void Update()
    {
        // �������Ƿ���G�����������帽��
        if (isPlayerNearby && Input.GetKeyDown(KeyCode.G))
        {
            AddIconToBox();
        }
    }

    private void AddIconToBox()
    {
        // ��Ŀ��Box�ϴ���һ���µ�Image���
        GameObject newIcon = new GameObject("Icon");
        newIcon.transform.SetParent(targetBox.transform, false);

        Image imageComponent = newIcon.AddComponent<Image>();
        imageComponent.sprite = objectIcon;
        imageComponent.rectTransform.sizeDelta = iconSize; // ����ͼ���С
        imageComponent.rectTransform.anchoredPosition = Vector2.zero; // ȷ��ͼ����Box������

        Debug.Log("Icon added to the box");
    }

    private void OnTriggerEnter(Collider other)
    {
        // �������Ƿ��������Ĵ�����Χ
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = true;
            Debug.Log("Player is nearby");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // �������Ƿ��뿪����Ĵ�����Χ
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = false;
            Debug.Log("Player left");
        }
    }
}
