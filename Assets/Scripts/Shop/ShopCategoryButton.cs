using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ShopCategoryButton : MonoBehaviour
{
    public event Action Clicked;

    [SerializeField] private Image _image;
    [SerializeField] private Color _selectedColor;
    [SerializeField] private Color _unSelectedColor;

    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(OnClick);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnClick);
    }

    public void Select()
    {
        _image.color = _selectedColor;
    }

    public void UnSelect()
    {
        _image.color = _unSelectedColor;
    }

    private void OnClick()
    {
        Clicked?.Invoke();
    }
}
