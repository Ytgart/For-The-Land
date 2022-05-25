using UnityEngine;
using Zenject;

public class HandPresenter : MonoBehaviour
{
    [Inject] 
    private readonly HandBindModel _handBm;
    [Inject] 
    private readonly HandView _handView;
    [Inject] 
    private readonly DiContainer _container;

    private void Awake()
    {
        _handBm.OnCardsChanged += _handView.PlaceCardsWithRotation;
    }

    public void AddCard(int id)
    {
        var card = _container.InstantiatePrefabResource("Prefabs/Card");
        card.GetComponent<CardInstaller>().CardId = id;
        card.GetComponent<CardPresenter>().CurrentHand = this;

        _handBm.AddCard(card);
    }

    public void RemoveCard(GameObject card)
    {
        _handBm.RemoveCard(card);
    }

    public void NotifyDragEnded()
    {
        _handBm.UpdateCards();
    }
}
