using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardView : MonoBehaviour
{
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

    public void RenderCard(Card card)
    {
        _description.text = card.Description;
        _name.text = card.Name;
        _attack.text = card.Attack.ToString();
        _health.text = card.Health.ToString();
        _cost.text = card.Cost.ToString();
        _image.sprite = card.Image;
    }
}
