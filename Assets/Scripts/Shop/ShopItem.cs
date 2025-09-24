using UnityEngine;

public abstract class ShopItem : ScriptableObject
{
    [field: SerializeField] public GameObject Model {  get; private set; }
    [field: SerializeField] public Sprite Image { get; private set; }
    [field: SerializeField, Range(0,999999)] public int Price { get; private set; }
    [field: SerializeField, Range(0, 999999)] public int Popularity { get; private set; }

}
