using UnityEngine;

public class ShowPopupOnApproach : MonoBehaviour
{
    public Transform player; // ��ҽ�ɫ��Transform
    public GameObject popupUI; // ����UIԪ��

    public float popupDistanceThreshold = 2f; // ���������ľ�����ֵ

    private void Update()
    {
        if (player == null || popupUI == null) return;

        // �������������֮��ľ���
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // �������С����ֵ������ʾ�������������ص���
        if (distanceToPlayer < popupDistanceThreshold)
        {
            popupUI.SetActive(true);

            // ��������λ������Ϊ���������ռ�����
            popupUI.transform.position = transform.position + Vector3.up * 2; // ����� 2 �ǵ����ĸ߶�ƫ��
        }
        else
        {
            popupUI.SetActive(false);
        }
    }
}
