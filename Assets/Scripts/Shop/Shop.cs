using System;
using System.Linq;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private ShopContent _contentItems;

    [SerializeField] private ShopCategoryButton _carsButton;
    [SerializeField] private ShopPanel _shopPanel;

    private void OnEnable()
    {
        _carsButton.Clicked += OnCarsButtonClick;
    }

    private void OnDisable()
    {
        _carsButton.Clicked -= OnCarsButtonClick;
    }

    private void OnCarsButtonClick()
    {
        _carsButton.Select();
        _shopPanel.Show(_contentItems.CarShopItems.Cast<ShopItem>());
    }
}
