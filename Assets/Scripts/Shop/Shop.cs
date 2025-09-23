using System;
using System.Linq;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private ShopContent _contentItems;

    [SerializeField] private ShopCategoryButton _carsButton;
    [SerializeField] private ShopCategoryButton _workersButton;
    [SerializeField] private ShopPanel _shopPanel;

    private void OnEnable()
    {
        _carsButton.Clicked += OnCarsButtonClick;
        _workersButton.Clicked += OnWorkersButtonClick;
    }

    private void OnDisable()
    {
        _carsButton.Clicked -= OnCarsButtonClick;
        _workersButton.Clicked -= OnWorkersButtonClick;
    }

    private void OnCarsButtonClick()
    {
        _carsButton.Select();
        _workersButton.UnSelect();
        _shopPanel.Show(_contentItems.CarShopItems.Cast<ShopItem>());
    }

    private void OnWorkersButtonClick()
    {
        _carsButton.UnSelect();
        _workersButton.Select();
        _shopPanel.Show(_contentItems.WorkerShopItems.Cast<ShopItem>());
    }
}
