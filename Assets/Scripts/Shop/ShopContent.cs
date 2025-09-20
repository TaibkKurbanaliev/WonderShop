using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ShopContent : ScriptableObject
{
    [SerializeField] private List<CarShopItem> _carShopItems;

    public IEnumerable<CarShopItem> CarShopItems => _carShopItems;

    private void OnValidate()
    {
        var haveCarDuplicates = _carShopItems.GroupBy(car => car.CarType).Where(array => array.Count() > 1).Count() > 1;

        if (haveCarDuplicates)
            throw new InvalidOperationException(nameof(_carShopItems));
    }
}
