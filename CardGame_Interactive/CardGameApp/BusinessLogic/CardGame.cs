

using System.Diagnostics;

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
             
             //Suffle the card deck
             _cardDeck.ShuffleCards();
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

    public void DealCards()
    {
     //Ask the deck for two random cards
     bool cardsDealt = _cardDeck.GetPairOfCards(out _playerCard, out _houseCard);
     Debug.Assert(cardsDealt, "Failed to get pair of cards, Game over Card deck empty");

    }
}
