using UnityEngine;
using Zenject;

public class HandInstaller : MonoInstaller
{
    [SerializeField]
    private HandView _handView;
    [SerializeField]
    private HandPresenter _handController;

    public override void InstallBindings()
    {
        Container.Bind<HandView>().FromInstance(_handView).AsSingle();
        Container.Bind<HandPresenter>().FromInstance(_handController).AsSingle();
        Container.Bind<HandBindModel>().FromNew().AsSingle();
    }
}
