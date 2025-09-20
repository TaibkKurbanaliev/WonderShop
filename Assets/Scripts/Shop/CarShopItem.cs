using UnityEngine;

[CreateAssetMenu(fileName = "Car", menuName = "Shop/Car")]
public class CarShopItem : ShopItem
{
    [field: SerializeField] public CarTypes CarType {  get; private set; }
}
