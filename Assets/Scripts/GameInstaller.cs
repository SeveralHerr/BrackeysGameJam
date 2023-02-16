using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        var hungerManager = new HungerManager();

        Container
            .Bind<IManager>()
            .FromInstance(hungerManager)
            .WhenInjectedInto<HungerDecreaseController>();

        Container
            .Bind<IManager>()
            .FromInstance(hungerManager)
            .WhenInjectedInto<HungerButtonPresenter>();

        Container
            .Bind<IManager>()
            .FromInstance(hungerManager)
            .WhenInjectedInto<HungerTextPresenter>();

        Container
            .Bind<IManager>()
            .FromInstance(hungerManager)
            .WhenInjectedInto<GameOverController>();


        var thirstManager = new ThirstManager();

        Container
           .Bind<IManager>()
           .FromInstance(thirstManager)
           .WhenInjectedInto<ThirstDecreaseController>();

        Container
            .Bind<IManager>()
            .FromInstance(thirstManager)
            .WhenInjectedInto<ThirstButtonPresenter>();

        Container
            .Bind<IManager>()
            .FromInstance(thirstManager)
            .WhenInjectedInto<ThirstTextPresenter>();



    }
}
