using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DebugPanel : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField _cardIdIP;
    [SerializeField]
    private Button _cardIdButton;
    [SerializeField]
    private HandPresenter _handController;

    private void Start()
    {
        _cardIdButton.onClick.AddListener(() =>
        {
            _handController.AddCard(int.Parse(_cardIdIP.text));
        });
    }
}
