using System;
using System.Collections.Generic;
using UnityEngine;

public class ShopPanel : MonoBehaviour
{
    [SerializeField] private Transform _itemsParrent;
    [SerializeField] private ShopItemViewFactory _factory;

    private List<ShopItemView> _shopItems = new();

    public void Show(IEnumerable<ShopItem> items)
    {
        Clear();
        foreach (var item in items)
        {
            ShopItemView spawned = _factory.Get(item, _itemsParrent);
            spawned.Click += OnItemViewClicked;

            _shopItems.Add(spawned);
        }
    }

    private void OnItemViewClicked(ShopItemView view)
    {
        throw new NotImplementedException();
    }

    private void Clear()
    {
        foreach (var item in _shopItems)
        {
            item.Click -= OnItemViewClicked;
            Destroy(item.gameObject);
        }

        _shopItems.Clear();
    }
}
