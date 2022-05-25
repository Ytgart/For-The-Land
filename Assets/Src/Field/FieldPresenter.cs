using UnityEngine;
using UnityEngine.EventSystems;
using Zenject;

public class FieldPresenter : MonoBehaviour, IDropHandler
{
    [Inject]
    private readonly FieldView _fieldView;
    [Inject]
    private readonly FieldBindModel _fieldBm;

    public void OnDrop(PointerEventData eventData)
    {
        eventData.pointerDrag.GetComponent<CardPresenter>().CurrentHand.RemoveCard(eventData.pointerDrag);
        eventData.pointerDrag.GetComponent<Canvas>().sortingOrder = -9;
        eventData.pointerDrag.transform.LeanMoveZ(0, 0.2f);
        eventData.pointerDrag.transform.SetParent(transform);
        (eventData.pointerDrag.transform as RectTransform).localRotation = Quaternion.Euler(0, 0, 0);
        (eventData.pointerDrag.transform as RectTransform).localScale = new Vector3(1, 1, 1);
    }
}
