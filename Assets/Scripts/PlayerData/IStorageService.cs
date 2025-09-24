using System;
using UnityEngine;

public interface IStorageService
{
    void Save(object data, Action<bool> callback = null);
    void Load<T>(Action<T> callback = null);
}
