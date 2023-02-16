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
    private IManager _manager;

    public void Start()
    {
        _text = gameObject.GetComponent<TextMeshProUGUI>();;

        _manager.Resource.Subscribe(_ => UpdateText(_manager.Resource.Value));

        UpdateText(_manager.Resource.Value);
    }

    private void UpdateText(int value)
    {
        _text.text = $"Hunger: {value}";
    }
}
