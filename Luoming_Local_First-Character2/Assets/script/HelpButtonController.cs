using UnityEngine;

public class HelpButtonController : MonoBehaviour
{
    public AudioSource tubeAudioSource; // 引用tube上的AudioSource
    public RectTransform arrowTransform; // 指示箭头的RectTransform
    public Transform tubeTransform; // tube对象的Transform
    public Transform playerTransform; // 玩家（或摄像机）的Transform

    private bool isArrowVisible = false;

    void Start()
    {
        // 确保tube的AudioSource组件已经设置好
        if (tubeAudioSource == null)
        {
            Debug.LogError("AudioSource is not assigned to the HelpButtonController script.");
        }

        // 初始时隐藏箭头
        if (arrowTransform != null)
        {
            arrowTransform.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        // 检测 "H" 键是否被按下
        if (Input.GetKeyDown(KeyCode.H))
        {
            PlayTubeSound();
            ToggleArrow();
        }

        // 如果箭头是显示状态，则持续更新其方向
        if (isArrowVisible)
        {
            UpdateArrowDirection();
        }
    }

    void PlayTubeSound()
    {
        // 播放tube的声音
        if (tubeAudioSource != null)
        {
            tubeAudioSource.Play();
        }
    }

    void ToggleArrow()
    {
        // 切换箭头的显隐状态
        isArrowVisible = !isArrowVisible;
        if (arrowTransform != null)
        {
            arrowTransform.gameObject.SetActive(isArrowVisible);

            // 如果箭头显示，则立即更新其方向
            if (isArrowVisible)
            {
                UpdateArrowDirection();
            }
        }
    }

    void UpdateArrowDirection()
    {
        // 计算玩家与tube之间的方向
        Vector3 directionToTube = tubeTransform.position - playerTransform.position;
        directionToTube.y = 0; // 忽略Y轴，保持箭头水平

        // 计算箭头指向的角度
        float angle = Mathf.Atan2(directionToTube.z, directionToTube.x) * Mathf.Rad2Deg;

        // 旋转箭头以指向tube方向
        arrowTransform.rotation = Quaternion.Euler(0, 0, -angle);
    }
}
