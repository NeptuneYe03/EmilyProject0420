using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    public GameObject taskButtonCanvas; // ��ʼCanvas
    public GameObject canvas2; // �ڶ���Canvas
    public GameObject canvas1; // ��һ����ϷCanvas
    public GameObject successCanvas; // �ɹ�Canvas

    public Button taskButton; // TaskButtonCanvas�е�TaskButton
    public Button goButton; // Canvas2�е�GoButton
    public Button successButton; // SuccessCanvas�е�SuccessButton

    public GameObject[] boxes; // Canvas1�е�6��Box
    public Sprite[] iconSprites; // ��Ӧ��6��IconImage
    public GameObject particleEffectPrefab; // ����Ч��Ԥ����

    private void Start()
    {
        // ��ʼ������
        ShowOnlyTaskButtonCanvas();

        // ��Ӱ�ť����¼�
        taskButton.onClick.AddListener(OnTaskButtonClicked);
        goButton.onClick.AddListener(OnGoButtonClicked);
        successButton.onClick.AddListener(OnSuccessButtonClicked);
    }

    public void ShowOnlyTaskButtonCanvas()
    {
        taskButtonCanvas.SetActive(true);
        canvas2.SetActive(false);
        canvas1.SetActive(false);
        successCanvas.SetActive(false);
    }

    public void ShowTaskButtonAndCanvas2()
    {
        taskButtonCanvas.SetActive(true);
        canvas2.SetActive(true);
        canvas1.SetActive(false);
        successCanvas.SetActive(false);
    }

    public void ShowOnlyCanvas1()
    {
        taskButtonCanvas.SetActive(false);
        canvas2.SetActive(false);
        canvas1.SetActive(true);
        successCanvas.SetActive(false);
    }

    public void ShowOnlySuccessCanvas()
    {
        taskButtonCanvas.SetActive(false);
        canvas2.SetActive(false);
        canvas1.SetActive(false);
        successCanvas.SetActive(true);
    }

    public void OnTaskButtonClicked()
    {
        ShowTaskButtonAndCanvas2();
    }

    public void OnGoButtonClicked()
    {
        ShowOnlyCanvas1();
    }

    public void OnSuccessButtonClicked()
    {
        ShowOnlyTaskButtonCanvas();
    }

    private void Update()
    {
        // ���Canvas1�е�����Box�Ƿ񶼱�����
        if (canvas1.activeSelf && AreAllBoxesFilled())
        {
            ShowOnlySuccessCanvas();
        }
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

    // ��ͼ����ӵ�ָ����Box�в���������Ч��
    public void AddIconToBox(int boxIndex)
    {
        if (boxIndex >= 0 && boxIndex < boxes.Length)
        {
            // ���IconImage
            Image boxImage = boxes[boxIndex].GetComponent<Image>();
            if (boxImage != null && boxIndex < iconSprites.Length)
            {
                boxImage.sprite = iconSprites[boxIndex];
            }

            // ��������������Ч��
            GameObject particleEffect = Instantiate(particleEffectPrefab, boxes[boxIndex].transform.position, Quaternion.identity);
            particleEffect.transform.SetParent(boxes[boxIndex].transform, false);
            Destroy(particleEffect, 2f); // ȷ������Ч����һ��ʱ�������
        }
    }
}
