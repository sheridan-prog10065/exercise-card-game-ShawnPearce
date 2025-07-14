namespace CardGameApp.BusinessLogic;

public class CardGame
{
    //Declare all the field variables
    private CardDeck _cardDeck;

    public CardGame()
    {
        _cardDeck = new CardDeck();
        Score = new GameScore();
        PlayerCard = null;
        HouseCard = null;
    }

    public GameScore Score { get; }

    public Card PlayerCard { get; }

    public Card HouseCard { get; }

    public bool PlayerWins => false;

    public bool HouseWins => false;

    public bool IsOver => false;
}