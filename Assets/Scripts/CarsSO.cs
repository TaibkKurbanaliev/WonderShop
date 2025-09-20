using System.Collections.Generic;
using UnityEngine;

public class CarsSO : ScriptableObject
{
    [SerializeField] private List<Car> _cars;

    public IEnumerable<Car> Cars => _cars;

    public void OnValidate()
    {
        
    }
}
