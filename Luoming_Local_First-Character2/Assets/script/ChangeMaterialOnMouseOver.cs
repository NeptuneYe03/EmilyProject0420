using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialOnMouseOver : MonoBehaviour
{
    public Material hoverMaterial; // Ҫ�������ͣʱӦ�õĲ���

    private Material originalMaterial; // ԭʼ���������

    private void Start()
    {
        // ����ԭʼ���������
        originalMaterial = GetComponent<Renderer>().material;
    }

    private void OnMouseEnter()
    {
        // ������ʱ��������Ĳ��ʸ�Ϊ��ͣ����
        if (hoverMaterial != null) // �����ͣ�����Ƿ��Ѹ�ֵ
        {
            GetComponent<Renderer>().material = hoverMaterial;
        }
    }

    private void OnMouseExit()
    {
        // ����뿪ʱ��������Ĳ��ʸĻ�ԭʼ����
        GetComponent<Renderer>().material = originalMaterial;
    }
}
