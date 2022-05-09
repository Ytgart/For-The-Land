using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    [SerializeField]
    private List<Card> _cards = new();

    public void AddCard(Card card)
    {
        _cards.Add(card);
    }
}
