using UnityEngine;
using Zenject;

public class CardInstaller : MonoInstaller
{
    [SerializeField]
    private CardView _cardView;

    [SerializeField]
    private CardController _cardController;

    [SerializeField]
    private GameObjectContext _context;

    private int _cardId;

    public int CardId
    {
        get => _cardId;
        set
        {
            if (value >= 0)
            {
                _cardId = value;
                _context.Run();
            }
            else _cardId = 0;
        }
    }

    public override void InstallBindings()
    {
        Container.Bind<CardView>().FromInstance(_cardView).AsSingle();
        Container.Bind<CardController>().FromInstance(_cardController).AsSingle();
        Container.Bind<CardBindModel>().FromNew().AsSingle();
        Container.Bind<Card>().FromResources($"Cards/{CardId}").AsSingle();
    }
}