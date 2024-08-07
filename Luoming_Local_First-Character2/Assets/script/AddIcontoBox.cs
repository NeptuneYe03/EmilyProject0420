using UnityEngine;
using UnityEngine.UI;

public class AddIconToBox : MonoBehaviour
{
    public GameObject iconPrefab; // Ҫ��ӵ�IconImageԤ����
    public GameObject particleEffectPrefab; // ����Ч��Ԥ����

    public void AddIcon(GameObject box)
    {
        // ���������IconImage
        GameObject newIcon = Instantiate(iconPrefab);
        newIcon.transform.SetParent(box.transform, false);

        // ��������������Ч��
        GameObject particleEffect = Instantiate(particleEffectPrefab, box.transform.position, Quaternion.identity);
        particleEffect.transform.SetParent(box.transform, false);
        Destroy(particleEffect, 2f); // ȷ������Ч����һ��ʱ�������
    }
}
