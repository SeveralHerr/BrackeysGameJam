using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using Zenject;

public class ThirstDecreaseController : MonoBehaviour
{
    [Inject]
    private IManager _ThirstManager;

    private readonly int _ThirstDecrement = 1;
    private readonly int _ThirstInterval = 1;

    private void Start()
    {
        StartCoroutine(HandleThirst());
    }

    IEnumerator HandleThirst()
    {
        while(_ThirstManager.Resource.Value > 0)
        {
            yield return new WaitForSeconds(_ThirstInterval);
            _ThirstManager.Subtract(_ThirstDecrement);
        }
    }
}
