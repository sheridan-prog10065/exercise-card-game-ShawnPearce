using CardGameApp.BusinessLogic;

namespace CardGameApp;

public partial class MainPage : ContentPage

{
    private CardGame _cardGame;
    public MainPage()
    {
        InitializeComponent();
        //Created the card game
        _cardGame = new CardGame();
    }

    private void onDealCards(object? sender, EventArgs e)
    {
       //Ask the game to deal the cards
       _cardGame.DealCards();
       //Display the player card
       Card playerCard = _cardGame.PlayerCard;
       ShowCard(_imgPlayerCard, playerCard);
       //Display the house card
       Card houseCard = _cardGame.HouseCard;
       ShowCard(_imgHouseCard, houseCard);
    }

    private void ShowCard(Image imgHouseCard, Card houseCard)
    {
       //TODO: Implement showing hte card based on the vlaue and suit of the card
    }
}