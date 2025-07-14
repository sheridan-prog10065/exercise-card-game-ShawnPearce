namespace CardGameApp.BusinessLogic;

public class Card
{
    public Card(byte value, CardSuit suit)
    {
        Value = value;
        Suit = suit;
    }

    public byte Value { get; set; }

    public CardSuit Suit { get; set; }

    public string CardName => "";

    public string SuitName => "";
}