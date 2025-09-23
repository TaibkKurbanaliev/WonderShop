using UnityEngine;

public class WorkerShopItem : ShopItem
{
    [field: SerializeField] public WorkerTypes WorkerType { get; private set; }
}
