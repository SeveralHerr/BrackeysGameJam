using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
public class HungerManager : Manager, IManager
{
    public override void Add(int value)
    {
        Resource.Value += value;
    }

    public override void Subtract(int value)
    {
        Resource.Value -= value;
    }
}

