using UnityEngine;

public class ChangeMaterialOnApproach : MonoBehaviour
{
    public Material newMaterial; // 新的材质
    public float detectionRadius = 5f; // 触发检测半径
    public Transform player; // 角色的Transform组件

    private Material originalMaterial; // 原始的材质
    private Renderer objectRenderer; // 该物体的Renderer组件

    void Start()
    {
        // 获取该物体的Renderer组件
        objectRenderer = GetComponent<Renderer>();

        // 保存原始材质
        originalMaterial = objectRenderer.material;
    }

    void Update()
    {
        // 计算角色和该物体之间的距离
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // 如果角色靠近该物体，则改变其材质
        if (distanceToPlayer < detectionRadius)
        {
            objectRenderer.material = newMaterial;
        }
        else
        {
            // 否则恢复原始材质
            objectRenderer.material = originalMaterial;
        }
    }
}
