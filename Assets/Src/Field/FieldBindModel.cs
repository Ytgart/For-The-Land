using System.Collections.Generic;

public class FieldBindModel
{
    private readonly List<Card> _cards;

    public void AddCard(Card card)
    {
        _cards.Add(card);
    }
}
