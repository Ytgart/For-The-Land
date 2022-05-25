using UnityEngine;
using Zenject;

public class FieldInstaller : MonoInstaller
{
    [SerializeField]
    private FieldView _handView;
    [SerializeField]
    private FieldPresenter _handController;

    public override void InstallBindings()
    {
        Container.Bind<FieldView>().FromInstance(_handView).AsSingle();
        Container.Bind<FieldPresenter>().FromInstance(_handController).AsSingle();
        Container.Bind<FieldBindModel>().FromNew().AsSingle();
    }
}
