using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class HungerManager : IHungerManager
{
    public ReactiveProperty<int> Hunger { get; private set; }
 
    public HungerManager()
    {
        Hunger = new ReactiveProperty<int>(10);
    }
    public void AddHunger(int value)
    {
        Hunger.Value += value;
    }

    public void RemoveHunger(int value)
    {
        Hunger.Value -= value;
    }
}