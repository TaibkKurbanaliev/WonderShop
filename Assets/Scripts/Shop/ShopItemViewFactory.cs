using System;
using UnityEngine;

[CreateAssetMenu(fileName = "ShopFactory", menuName = "Shop/Factory")]
public class ShopItemViewFactory : ScriptableObject
{
    [SerializeField] private ShopItemView _shopItemPrefab;

    public ShopItemView Get(ShopItem item, Transform parent)
    {
        ShopItemView instance;

        switch (item)
        {
            case CarShopItem carShopItem:
                instance = Instantiate(_shopItemPrefab, parent);
                break;

            case WorkerShopItem workerShopItem:
                instance = Instantiate(_shopItemPrefab, parent);
                break;

            default:
                throw new NotImplementedException(nameof(item));
        }

        instance.Initialize(item);
        return instance;
    }
}
