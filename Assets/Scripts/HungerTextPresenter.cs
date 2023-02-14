using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class HungerTextPresenter : MonoBehaviour
{
    private TextMeshProUGUI _text;

    [Inject]
    private IHungerManager _manager;

    public void Start()
    {
        _text = gameObject.GetComponent<TextMeshProUGUI>();;

        _manager.Hunger.Subscribe(_ => UpdateText(_manager.Hunger.Value));

        UpdateText(_manager.Hunger.Value);
    }

    private void UpdateText(int value)
    {
        _text.text = $"Hunger: {value}";
    }
}
