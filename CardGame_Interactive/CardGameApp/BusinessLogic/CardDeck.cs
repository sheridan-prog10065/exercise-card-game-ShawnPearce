namespace CardGameApp.BusinessLogic;

public class CardDeck
{
    private List<Card> _cardList;
    private int MAX_SUIT_COUNT = 4;
    private int MAX_CARD_VALUE = 14;

    public CardDeck()
    {
        _cardList = new List<Card>();
        //Fill the deck of cards
        CreateCards();
    }

    public int CardCount
    {
        get { return _cardList.Count; }
    }

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
}
