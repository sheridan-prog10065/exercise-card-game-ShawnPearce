
using System.Diagnostics;

namespace CardGameApp.BusinessLogic;

public class Card
{
    private byte _value;
    private CardSuit _suit;

public Card(byte value, CardSuit suit)
    {
        _value = value;
        _suit = suit;
        
    }
    public byte Value
    {
        get { return _value; }
        set { _value = value; }
    }
    public CardSuit Suit
    {
        get { return _suit; }
        set { _suit = value; }
    }

    public string CardName
    {
        get
        {
            //Determine the name of the card based on its litteral value
            switch (_value)
            {
                
                case 1:
                    return "Ace";
                case 11:
                    return "Jack";
                case 12:
                    return "Queen";
                case 13:
                    return "King";
                default:
                    //For all values 2-10
                   return _value.ToString("00");
            }
           
        }
    }

    public string SuitName
    {
        //Determine the name of the suit based on its litteral value
        get
        {
            switch (_suit)
            {
                case CardSuit.Diamonds:
                    return "Diamonds";
                case CardSuit.Clubs:
                    return "Clubs";
                case CardSuit.Hearts:
                    return "Hearts";
                case CardSuit.Spades:
                    return "Spades";
                default:
                    //Use defensive programing
                    Debug.Assert(false, "Invalid suit");
                    return "";
                
            }
            
            
        }
    }
}