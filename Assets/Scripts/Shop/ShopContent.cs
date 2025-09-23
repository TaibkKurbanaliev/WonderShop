using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ShopContent : ScriptableObject
{
    [SerializeField] private List<CarShopItem> _carShopItems;
    [SerializeField] private List<WorkerShopItem> _workerShopItems;

    public IEnumerable<CarShopItem> CarShopItems => _carShopItems;
    public IEnumerable<WorkerShopItem> WorkerShopItems => _workerShopItems;

    private void OnValidate()
    {
        var haveCarDuplicates = _carShopItems.GroupBy(car => car.CarType).Where(array => array.Count() > 1).Count() > 1;

        if (haveCarDuplicates)
            throw new InvalidOperationException(nameof(_carShopItems));

        var haveWorkerDuplicates = _workerShopItems.GroupBy(worker => worker.WorkerType).Where(array => array.Count() > 1).Count() > 1;

        if (haveWorkerDuplicates)
            throw new InvalidOperationException(nameof(_carShopItems));
    }
}
