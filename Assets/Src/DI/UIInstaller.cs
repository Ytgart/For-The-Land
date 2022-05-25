using UnityEngine;
using Zenject;

public class UIInstaller : MonoInstaller
{
    [SerializeField]
    private Canvas _mainUICanvas;

    public override void InstallBindings()
    {
        Container.Bind<Canvas>().FromInstance(_mainUICanvas).AsSingle();
    }
}