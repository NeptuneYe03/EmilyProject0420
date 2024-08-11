using UnityEngine;

public class ArrowIndicatorController : MonoBehaviour
{
    public Transform tubeTransform; // tube�����Transform
    public Transform playerTransform; // ��ң������������Transform

    private RectTransform arrowTransform; // ָʾ��ͷ��RectTransform
    private bool isArrowVisible = false;

    void Start()
    {
        // ��ȡ��ǰ�����RectTransform���
        arrowTransform = GetComponent<RectTransform>();

        // ��ʼʱ���ؼ�ͷ
        arrowTransform.gameObject.SetActive(false);
    }

    void Update()
    {
        // ��� "H" ���Ƿ񱻰���
        if (Input.GetKeyDown(KeyCode.H))
        {
            isArrowVisible = !isArrowVisible; // �л���ͷ����״̬
            arrowTransform.gameObject.SetActive(isArrowVisible);

            // �����ͷ��ʾ��������䷽��
            if (isArrowVisible)
            {
                UpdateArrowDirection();
            }
        }

        // �����ͷ����ʾ״̬������������䷽��
        if (isArrowVisible)
        {
            UpdateArrowDirection();
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
