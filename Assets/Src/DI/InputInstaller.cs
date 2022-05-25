using UnityEngine;
using Zenject;

public class InputInstaller : MonoInstaller
{
    [SerializeField] 
    private InputHandler _inputHandler;
    [SerializeField]
    private CameraBehavior _cameraBehavior;

    public override void InstallBindings()
    {
        Container.Bind<InputHandler>().FromInstance(_inputHandler).AsSingle();
        Container.Bind<CameraBehavior>().FromInstance(_cameraBehavior).AsSingle();
    }
}