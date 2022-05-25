using System;
using System.Collections.Generic;
using UnityEngine;

public class HandBindModel
{
    private readonly List<GameObject> _cards = new();

    public Action<List<GameObject>> OnCardsChanged;

    public void AddCard(GameObject card) 
    {
        _cards.Add(card);
        OnCardsChanged.Invoke(_cards);
    }

    public void RemoveCard(GameObject card)
    {
        _cards.Remove(card);
        OnCardsChanged.Invoke(_cards);
    }

    public void UpdateCards()
    {
        OnCardsChanged.Invoke(_cards);
    }
}
