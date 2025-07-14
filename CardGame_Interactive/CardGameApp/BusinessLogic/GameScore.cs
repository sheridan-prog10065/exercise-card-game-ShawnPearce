namespace CardGameApp.BusinessLogic;

public struct GameScore
{
    private int _houseScore;

    public GameScore(int playerScore, int houseScore)
    {
        PlayerScore = playerScore;
        _houseScore = houseScore;
    }

    public int PlayerScore { get; set; }

    public int HouseScore
    {
        get => PlayerScore;
        set => PlayerScore = value;
    }
}