using UnityEngine;
using UnityEngine.EventSystems;
using Zenject;

public class CardPresenter : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    [Inject]
    private readonly CardView _cardView;
    [Inject]
    private readonly CardBindModel _cardBm;
    [Inject]
    private readonly Card _card;
    [Inject]
    private readonly InputHandler _inputHandler;
    [Inject]
    private readonly CameraBehavior _cameraBehavior;
    [Inject]
    private readonly CanvasGroup _canvasGroup;
    [Inject]
    private readonly Canvas _canvas;

    private HandPresenter _currentHand;
    private int zOrder;

    public HandPresenter CurrentHand { get => _currentHand; set { _currentHand = value; } }

    private void Start()
    {
        _cardBm.OnCardLoaded += _cardView.RenderCard;
        _cardBm.OnCardLoaded?.Invoke(_card);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        _cameraBehavior.IsNeedToMoveCamera = false;
        _canvasGroup.blocksRaycasts = false;
        transform.SetParent(_canvas.transform);
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        _currentHand.NotifyDragEnded();
        _cameraBehavior.IsNeedToMoveCamera = true;
        _canvasGroup.blocksRaycasts = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        var mousePosition = _inputHandler.GetMousePosition();
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 1) - new Vector3(0, 96, 0));
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.LeanScale(new Vector3(1.3f, 1.3f, 1.3f), 0.2f).setEaseInSine();

        var canvas = gameObject.GetComponent<Canvas>();
        zOrder = canvas.sortingOrder;
        canvas.sortingOrder = 99;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.LeanScale(new Vector3(1, 1, 1), 0.2f);

        var canvas = gameObject.GetComponent<Canvas>();
        canvas.sortingOrder = zOrder;
    }
}
