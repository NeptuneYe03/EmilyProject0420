using UnityEngine;
using UnityEngine.UI;

public class HoverImage : MonoBehaviour
{
    public Sprite normalSprite;
    public Sprite hoverSprite;
    public Button[] buttons;

    private Image image;

    void Start()
    {
        image = GetComponent<Image>();
        image.sprite = normalSprite;
        SetButtonsActive(false);
    }

    public void OnPointerEnter()
    {
        image.sprite = hoverSprite;
        SetButtonsActive(true);
    }

    public void OnPointerExit()
    {
        image.sprite = normalSprite;
        SetButtonsActive(false);
    }

    private void SetButtonsActive(bool active)
    {
        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(active);
        }
    }
}
