using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{
    private Card _card;

    [SerializeField]
    private Text _name;

    [SerializeField]
    private Text _description;

    [SerializeField]
    private Image _image;

    [SerializeField]
    private Text _attack;

    [SerializeField]
    private Text _defence;

    [SerializeField]
    private Text _cost;

    void Start()
    {
        _description.text = _card.Description;
        _name.text = _card.Name;
        _attack.text = _card.Attack.ToString();
        _defence.text = _card.Defence.ToString();
        _cost.text = _card.Cost.ToString();
    }
}
