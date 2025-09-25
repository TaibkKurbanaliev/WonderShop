using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [SerializeField] private ShopContent _contentItems;

    [SerializeField] private ShopCategoryButton _carsButton;
    [SerializeField] private ShopCategoryButton _workersButton;
    [SerializeField] private Button _closeButton;
    [SerializeField] private ShopPanel _shopPanel;

    private void OnEnable()
    {
        _carsButton.Clicked += OnCarsButtonClick;
        _workersButton.Clicked += OnWorkersButtonClick;
        _closeButton.onClick.AddListener(OnClose);
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

    private void OnClose()
    {
        _carsButton.UnSelect();
        _workersButton.UnSelect();
        gameObject.SetActive(false);
    }
}
