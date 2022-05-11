using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Zenject;

public class CardView : MonoBehaviour
{
    [Inject] private Card _card;

    [SerializeField]
    private TMP_Text _name;

    [SerializeField]
    private TMP_Text _description;

    [SerializeField]
    private Image _image;

    [SerializeField]
    private TMP_Text _attack;

    [SerializeField]
    private TMP_Text _health;

    [SerializeField]
    private TMP_Text _cost;

    void Start()
    {
        _description.text = _card.Description;
        _name.text = _card.Name;
        _attack.text = _card.Attack.ToString();
        _health.text = _card.Health.ToString();
        _cost.text = _card.Cost.ToString();
        _image.sprite = _card.Image;
    }
}
