using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using Zenject;

public class HungerDecreaseController : MonoBehaviour
{
    [Inject]
    private IManager _hungerManager;

    private readonly int _hungerDecrement = 1;
    private readonly int _hungerInterval = 1;

    private void Start()
    {
        StartCoroutine(HandleHunger());
    }

    IEnumerator HandleHunger()
    {
        while(_hungerManager.Resource.Value > 0)
        {
            yield return new WaitForSeconds(_hungerInterval);
            _hungerManager.Subtract(_hungerDecrement);
        }
    }
}
