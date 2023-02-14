using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class HungerButtonPresenter : MonoBehaviour
{
    public Button _button;

    private ReactiveProperty<bool> _canExecute = new ReactiveProperty<bool>();

    [Inject]
    private IHungerManager _manager;

    void Start()
    {
        _canExecute.Value = true;

        // Throttle clicks
        _button.BindToOnClick(_canExecute, (value) =>
        {
            _manager.AddHunger(1);
            return Observable.Timer(TimeSpan.FromSeconds(3)).AsUnitObservable();
        });
    }
}
