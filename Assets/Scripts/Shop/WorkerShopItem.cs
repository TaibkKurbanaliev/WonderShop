using UnityEngine;

[CreateAssetMenu(fileName = "Car", menuName = "Shop/Worker")]
public class WorkerShopItem : ShopItem
{
    [field: SerializeField] public WorkerTypes WorkerType { get; private set; }
}
