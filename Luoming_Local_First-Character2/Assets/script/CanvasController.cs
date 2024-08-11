using UnityEngine;
using UnityEngine.UI;
using StarterAssets;
using System.Collections;

public class CanvasController : MonoBehaviour
{
    public GameObject taskButtonCanvas; // ��ʼCanvas
    public GameObject canvas2; // �ڶ���Canvas
    public GameObject canvas1; // ��һ����ϷCanvas
    public GameObject successCanvas; // �ɹ�Canvas��WinConfetti�����Ӷ���

    public Button goButton; // Canvas2�е�GoButton
    public Button successButton; // SuccessCanvas�е�SuccessButton

    public GameObject[] boxes; // Canvas1�е�6��Box
    public Sprite[] iconSprites; // ��Ӧ��6��IconImage
    //public GameObject particleEffectPrefab; // ����Ч��Ԥ���壬������Ҫ��������

    private FirstPersonController playerController; // ���õ�һ�˳ƿ������ű�
    private bool isCursorLocked = true;

    private void Start()
    {
        // ��ʼ������
        ShowOnlyTaskButtonCanvas();

        // ��ȡ��һ�˳ƿ������ű�
        playerController = FindObjectOfType<FirstPersonController>();

        // ��Ӱ�ť����¼�
        goButton.onClick.AddListener(OnGoButtonClicked);
        successButton.onClick.AddListener(OnSuccessButtonClicked);
    }

    private void Update()
    {
        // ���Canvas1�е�����Box�Ƿ񶼱�����
        if (canvas1.activeSelf && AreAllBoxesFilled())
        {
            ShowOnlySuccessCanvas();
        }

        // ����Ƿ���Q��
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ShowTaskButtonAndCanvas2();
        }
    }

    public void ShowOnlyTaskButtonCanvas()
    {
        taskButtonCanvas.SetActive(true);
        canvas2.SetActive(false);
        canvas1.SetActive(false);
        successCanvas.SetActive(false);

        LockCursor(true); // �����������ӽ�
    }

    public void ShowTaskButtonAndCanvas2()
    {
        taskButtonCanvas.SetActive(true);
        canvas2.SetActive(true);
        canvas1.SetActive(false);
        successCanvas.SetActive(false);

        LockCursor(false); // ������꣬����UI����
    }

    public void ShowOnlyCanvas1()
    {
        taskButtonCanvas.SetActive(false);
        canvas2.SetActive(false);
        canvas1.SetActive(true);
        successCanvas.SetActive(false);

        LockCursor(true); // �����������ӽ�
    }

    public void ShowOnlySuccessCanvas()
    {
        taskButtonCanvas.SetActive(false);
        canvas2.SetActive(false);
        canvas1.SetActive(false);
        successCanvas.SetActive(true); // ��ʾSuccessCanvas�������Ӷ��󣬰���WinConfetti

        LockCursor(false); // ������꣬����UI����
    }

    public void OnGoButtonClicked()
    {
        ShowOnlyCanvas1();
    }

    public void OnSuccessButtonClicked()
    {
        ShowOnlyTaskButtonCanvas();
    }

    private bool AreAllBoxesFilled()
    {
        foreach (GameObject box in boxes)
        {
            if (box.transform.childCount == 0)
            {
                return false;
            }
        }
        return true;
    }

    private void LockCursor(bool lockCursor)
    {
        isCursorLocked = lockCursor;

        if (isCursorLocked)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            if (playerController != null)
            {
                playerController.enabled = true; // ���������ӽǿ���
            }
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            if (playerController != null)
            {
                playerController.enabled = false; // ���������ӽǿ���
            }
        }
    }
}
