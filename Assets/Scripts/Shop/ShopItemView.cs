using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopItemView : MonoBehaviour, IPointerClickHandler
{
    public event Action<ShopItemView> Click;

    [SerializeField] private Sprite _standardBackground;
    [SerializeField] private Sprite _highlightedBackground;

    [SerializeField] private Image _contentImage;
    [SerializeField] private Image _lockedImage;

    [SerializeField] private IntValueView _priceView;

    [SerializeField] private Image _selectionText;

    private Image _backgroundImage;

    public bool IsLocked { get; private set; }

    public ShopItem Item { get; private set; }
    public int Price => Item.Price;
    public GameObject Model => Item.Model;

    public void Initialize(ShopItem item)
    {
        _backgroundImage = GetComponent<Image>();
        _backgroundImage.sprite = _standardBackground;

        Item = item;

        _contentImage.sprite = Item.Image;

        _priceView.Show(Price);
    }

    public void OnPointerClick(PointerEventData eventData) => Click?.Invoke(this);
    
    public void Lock()
    {
        IsLocked = true;
        _lockedImage.gameObject.SetActive(IsLocked);
        _priceView.Hide();
    }

    public void Unlock()
    {
        IsLocked = false;
        _lockedImage.gameObject.SetActive(IsLocked);
        _priceView.Show(Price);
    }

    public void Select() => _selectionText.gameObject.SetActive(true);
    public void UnSelect() => _selectionText.gameObject.SetActive(false);

    public void Highlight() => _backgroundImage.sprite = _highlightedBackground;
    public void UnHighlight() => _backgroundImage.sprite = _standardBackground;

}
