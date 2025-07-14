namespace CardGameApp.BusinessLogic;

public class CardDeck
{
    private readonly List<Card> _cardList;

    public CardDeck()
    {
        _cardList = new List<Card>();
    }

    public int CardCount => _cardList.Count;
}