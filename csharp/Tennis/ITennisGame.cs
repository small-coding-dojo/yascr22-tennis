namespace Tennis
{
    public interface ITennisGame
    {
        void AddOnePointToPlayer(string playerName);
        string GetScore();
    }
}

