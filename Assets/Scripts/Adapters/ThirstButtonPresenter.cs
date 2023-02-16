using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class ThirstButtonPresenter : MonoBehaviour
{
    public Button _button;

    private readonly ReactiveProperty<bool> _canExecute = new();

    private readonly int _cooldown = 3;
    private readonly int _increaseAmount = 5;

    [Inject]
    private IManager _manager;

    void Start()
    {
        _canExecute.Value = true;

        // Throttle clicks
        _button.BindToOnClick(_canExecute, (value) =>
        {
            _manager.Add(_increaseAmount);
            return Observable.Timer(TimeSpan.FromSeconds(_cooldown)).AsUnitObservable();
        });
    }
}
