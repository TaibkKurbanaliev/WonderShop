using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopItemView : MonoBehaviour, IPointerClickHandler
{
    public event Action<ShopItemView> Click;


    [SerializeField] private Sprite _buyedBackground;

    [SerializeField] private Image _contentImage;
    [SerializeField] private Image _lockedImage;

    [SerializeField] private IntValueView _priceView;
    [SerializeField] private IntValueView _popularityView;

    [SerializeField] private Image _selectionText;

    private Image _backgroundImage;

    public bool IsLocked { get; private set; }

    public ShopItem Item { get; private set; }
    public int Price => Item.Price;
    public int Popularity => Item.Popularity;
    public GameObject Model => Item.Model;

    public void Initialize(ShopItem item)
    {
        _backgroundImage = GetComponent<Image>();

        Item = item;

        _contentImage.sprite = Item.Image;

        _priceView.Show(Price);
    }

    public void OnPointerClick(PointerEventData eventData) => Click?.Invoke(this);
    
    public void Lock()
    {
        IsLocked = true;
        _lockedImage.gameObject.SetActive(IsLocked);
        _popularityView.Show(Popularity);
        _priceView.Hide();
    }

    public void Unlock()
    {
        IsLocked = false;
        _lockedImage.gameObject.SetActive(IsLocked);
        _priceView.Show(Price);
        _popularityView.Hide();
    }

    public void Buy()
    {
        _backgroundImage.sprite = _buyedBackground;
    }

}
