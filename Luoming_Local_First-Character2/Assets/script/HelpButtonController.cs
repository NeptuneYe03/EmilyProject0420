using UnityEngine;

public class HelpButtonController : MonoBehaviour
{
    public AudioSource tubeAudioSource; // ����tube�ϵ�AudioSource
    public RectTransform arrowTransform; // ָʾ��ͷ��RectTransform
    public Transform tubeTransform; // tube�����Transform
    public Transform playerTransform; // ��ң������������Transform

    private bool isArrowVisible = false;

    void Start()
    {
        // ȷ��tube��AudioSource����Ѿ����ú�
        if (tubeAudioSource == null)
        {
            Debug.LogError("AudioSource is not assigned to the HelpButtonController script.");
        }

        // ��ʼʱ���ؼ�ͷ
        if (arrowTransform != null)
        {
            arrowTransform.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        // ��� "H" ���Ƿ񱻰���
        if (Input.GetKeyDown(KeyCode.H))
        {
            PlayTubeSound();
            ToggleArrow();
        }

        // �����ͷ����ʾ״̬������������䷽��
        if (isArrowVisible)
        {
            UpdateArrowDirection();
        }
    }

    void PlayTubeSound()
    {
        // ����tube������
        if (tubeAudioSource != null)
        {
            tubeAudioSource.Play();
        }
    }

    void ToggleArrow()
    {
        // �л���ͷ������״̬
        isArrowVisible = !isArrowVisible;
        if (arrowTransform != null)
        {
            arrowTransform.gameObject.SetActive(isArrowVisible);

            // �����ͷ��ʾ�������������䷽��
            if (isArrowVisible)
            {
                UpdateArrowDirection();
            }
        }
    }

    void UpdateArrowDirection()
    {
        // ���������tube֮��ķ���
        Vector3 directionToTube = tubeTransform.position - playerTransform.position;
        directionToTube.y = 0; // ����Y�ᣬ���ּ�ͷˮƽ

        // �����ͷָ��ĽǶ�
        float angle = Mathf.Atan2(directionToTube.z, directionToTube.x) * Mathf.Rad2Deg;

        // ��ת��ͷ��ָ��tube����
        arrowTransform.rotation = Quaternion.Euler(0, 0, -angle);
    }
}
