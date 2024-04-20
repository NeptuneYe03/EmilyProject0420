using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialOnMouseOver : MonoBehaviour
{
    public Material hoverMaterial; // 要在鼠标悬停时应用的材质

    private Material originalMaterial; // 原始的物体材质

    private void Start()
    {
        // 保存原始的物体材质
        originalMaterial = GetComponent<Renderer>().material;
    }

    private void OnMouseEnter()
    {
        // 鼠标进入时，将物体的材质改为悬停材质
        if (hoverMaterial != null) // 检查悬停材质是否已赋值
        {
            GetComponent<Renderer>().material = hoverMaterial;
        }
    }

    private void OnMouseExit()
    {
        // 鼠标离开时，将物体的材质改回原始材质
        GetComponent<Renderer>().material = originalMaterial;
    }
}
