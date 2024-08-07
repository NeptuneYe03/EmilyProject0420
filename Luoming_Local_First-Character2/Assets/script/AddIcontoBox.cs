using UnityEngine;
using UnityEngine.UI;

public class AddIconToBox : MonoBehaviour
{
    public GameObject iconPrefab; // 要添加的IconImage预制体
    public GameObject particleEffectPrefab; // 粒子效果预制体

    public void AddIcon(GameObject box)
    {
        // 创建并添加IconImage
        GameObject newIcon = Instantiate(iconPrefab);
        newIcon.transform.SetParent(box.transform, false);

        // 创建并播放粒子效果
        GameObject particleEffect = Instantiate(particleEffectPrefab, box.transform.position, Quaternion.identity);
        particleEffect.transform.SetParent(box.transform, false);
        Destroy(particleEffect, 2f); // 确保粒子效果在一段时间后被销毁
    }
}
