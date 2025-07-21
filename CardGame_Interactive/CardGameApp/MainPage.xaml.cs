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
}