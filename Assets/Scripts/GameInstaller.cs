using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        var manager = new HungerManager();
        //var presenter = 


        Container
            .Bind<IHungerManager>()
            .FromInstance(manager);
    }
}
