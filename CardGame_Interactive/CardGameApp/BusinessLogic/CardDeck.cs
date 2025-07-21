namespace CardGameApp.BusinessLogic;

public class CardDeck
{

    #region field varialbes

    private List<Card> _cardList;
    private const int MAX_SUIT_COUNT = 4;
    private const int MAX_CARD_VALUE = 14;
    private static Random s_randomizer;

    #endregion

    #region Constructor

    static CardDeck()
    {
        s_randomizer = new Random();
    }

    public CardDeck()
    {
        _cardList = new List<Card>();
        //Fill the deck of cards
        CreateCards();
    }

    #endregion

    #region Properties

    public int CardCount
    {
        get { return _cardList.Count; }
    }

    #endregion

    #region Methods

    private void CreateCards()
    {
        //repeate for each of the four suites

        for (byte iSuit = 1; iSuit < MAX_SUIT_COUNT; iSuit++)
        {
            CardSuit suit = (CardSuit)iSuit;

            //repeate for each value in a suit
            for (byte value = 1; value < MAX_CARD_VALUE; value++)
            {

                //create a card with the current value and suit

                Card card = new Card(value, suit);


                //add the card to the list
                _cardList.Add(card);
            }
        }
    }

    public void ShuffleCards()
    {
        // Shuffle the card deck using a fisher-yates shuffle
        //take a random number in the array and swap it with the first location that has not been randomized in the array until all objects have been randomized
        for (int iCard = 0; iCard < _cardList.Count; iCard++)
        {
            int randomIndex = s_randomizer.Next(iCard, _cardList.Count);
            Card randomCard = _cardList[randomIndex];
            Card crtCard = _cardList[iCard];
            _cardList[iCard] = randomCard;
            _cardList[randomIndex] = crtCard;

        }
    }

    #endregion


    public bool GetPairOfCards(out Card playerCard, out Card houseCard)
    {
        //Check that their are enough cards in the deck
        if (_cardList.Count > 2)
        {
            //extract a random card from the deck
            int randPos = s_randomizer.Next(_cardList.Count);
            //access the card with a random index
            playerCard = _cardList[randPos];
            //remove this card from the deck
            _cardList.RemoveAt(randPos);
            //extract a second random card form the deck
            randPos = s_randomizer.Next(_cardList.Count);
            //access the card with a random index
            houseCard = _cardList[randPos];
            //remove this card from the deck
            _cardList.RemoveAt(randPos);
            return true;
        }
        else
        {
            playerCard = null;
            houseCard = null;
            //There are not enough cards in the deck
            return false;
        }

    }
}
