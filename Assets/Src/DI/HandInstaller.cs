using UnityEngine;
using Zenject;

public class HandInstaller : MonoInstaller
{
    [SerializeField]
    private HandView _handView;

    [SerializeField]
    private HandController _handController;

    public override void InstallBindings()
    {
        Container.Bind<HandView>().FromInstance(_handView).AsSingle();
        Container.Bind<HandController>().FromInstance(_handController).AsSingle();
        Container.Bind<HandBindModel>().FromNew().AsSingle();
    }
}
