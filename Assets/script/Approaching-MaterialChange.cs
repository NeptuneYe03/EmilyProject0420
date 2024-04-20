using UnityEngine;

public class ChangeMaterialOnApproach : MonoBehaviour
{
    public Material newMaterial; // �µĲ���
    public float detectionRadius = 5f; // �������뾶
    public Transform player; // ��ɫ��Transform���

    private Material originalMaterial; // ԭʼ�Ĳ���
    private Renderer objectRenderer; // �������Renderer���

    void Start()
    {
        // ��ȡ�������Renderer���
        objectRenderer = GetComponent<Renderer>();

        // ����ԭʼ����
        originalMaterial = objectRenderer.material;
    }

    void Update()
    {
        // �����ɫ�͸�����֮��ľ���
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // �����ɫ���������壬��ı������
        if (distanceToPlayer < detectionRadius)
        {
            objectRenderer.material = newMaterial;
        }
        else
        {
            // ����ָ�ԭʼ����
            objectRenderer.material = originalMaterial;
        }
    }
}
