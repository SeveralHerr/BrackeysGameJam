using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using Zenject;

public class HungerController : MonoBehaviour
{
    [Inject]
    private IHungerManager _hungerManager;

    public int HungerDecrement = 1;

    private void Start()
    {
        StartCoroutine(HandleHunger());
    }

    IEnumerator HandleHunger()
    {
        while(_hungerManager.Hunger.Value > 0)
        {
            yield return new WaitForSeconds(3);
            _hungerManager.RemoveHunger(HungerDecrement);
        }
    }
}
