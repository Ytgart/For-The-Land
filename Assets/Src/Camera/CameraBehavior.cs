using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private InputHandler _inputHandler;

    public bool IsNeedToMoveCamera { get; set; } = true;

    void Update()
    {
        if (_inputHandler.MainInput.Main.MouseClickLeft.ReadValue<float>() >= 1 && IsNeedToMoveCamera)
        {
            _camera.transform.position -= (Vector3)_inputHandler.MainInput.Main.MouseDelta.ReadValue<Vector2>() / 2;
        }
    }
}