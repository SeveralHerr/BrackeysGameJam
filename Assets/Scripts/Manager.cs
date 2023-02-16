using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public abstract class Manager
{
    public ReactiveProperty<int> Resource { get; set; }

    public Manager()
    {
        Resource = new ReactiveProperty<int>(10);
    }

    public abstract void Add(int value);
    public abstract void Subtract(int value);
}