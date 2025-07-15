

namespace CardGameApp.BusinessLogic;

public class CardGame
{
    //Declare all the field variables
    private CardDeck _cardDeck;
    private GameScore _score;
    private Card _playerCard;
    private Card _houseCard;
    public CardGame() 
        {
             _cardDeck = new CardDeck(); 
             _score = new GameScore(); 
             _playerCard = null; 
             _houseCard = null;    
        }

    public GameScore Score
    {
        get { return _score; }
    }
    public Card PlayerCard
    {
        get { return _playerCard; }
    }
    public Card HouseCard
    {
        get { return _houseCard; }
    }

    public bool PlayerWins
    {
        get { return false; }
    }
        public bool HouseWins
    {
        get { return false;}
    }

    public bool IsOver
    {
        get { return false; }
    }
}
