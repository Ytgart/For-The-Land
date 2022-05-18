using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Zenject;
using UnityEngine.EventSystems;

public class CardView : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IDragHandler
{
    [Inject] 
    private Card _card;

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

    private int zOrder;

    public void OnDrag(PointerEventData eventData)
    {
        var rectTransform = (transform as RectTransform);
        rectTransform.anchoredPosition += eventData.delta;
        rectTransform.SetParent(null);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.LeanScale(new Vector3(1.3f, 1.3f, 1.3f), 0.3f).setEaseInSine();

        var canvas = gameObject.GetComponent<Canvas>();
        zOrder = canvas.sortingOrder;
        canvas.sortingOrder = 99;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.LeanScale(new Vector3(1, 1, 1), 0.3f);

        var canvas = gameObject.GetComponent<Canvas>();
        canvas.sortingOrder = zOrder;
    }

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
