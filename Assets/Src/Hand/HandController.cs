using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class HandController : MonoBehaviour
{
    [Inject] private HandBindModel _handBm;
    [Inject] private HandView _handView;
    [Inject] private DiContainer _container;

    [SerializeField]
    private List<GameObject> _cards = new();

    private void Awake()
    {
        _handBm.OnCardsChanged += _handView.PlaceCardsWithRotation;
    }

    public void AddCard(int id)
    {
        var card = _container.InstantiatePrefabResource("Prefabs/Card");
        card.GetComponent<CardInstaller>().CardId = id;
        _cards.Add(card);
        _handBm.OnCardsChanged.Invoke(_cards);
    }
}
