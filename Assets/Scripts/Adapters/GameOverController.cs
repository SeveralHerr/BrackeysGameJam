using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using Zenject;

public class GameOverController : MonoBehaviour 
{
    //public GameObject GameOverObject;

    [Inject]
    private readonly IManager _hungerManager;

    private void Start()
    {
        _hungerManager.Resource
            .Where(value => value <= 0)
            .Subscribe(_ =>  GameOver());
    }

    private void GameOver()
    {
        Debug.Log("GameOver");
    }
}
