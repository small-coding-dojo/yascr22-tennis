using System;

namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private int p2; // player 2 points variable names?
        private int p1; 
        private string p1N;
        private string p2N;
        private readonly string[] _pointsToString = { "Love", "Fifteen", "Thirty", "Forty" };

        public TennisGame3(string player1Name, string player2Name)
        {
            this.p1N = player1Name;
            this.p2N = player2Name;
        }

        public bool IsNormalScoring()
        {
            return ((p1 < 4 && p2 < 4) && (p1 + p2 < 6));
        }
        
        public string GetScore()
        {
            if (IsNormalScoring())
            {
                return (p1 == p2) ? _pointsToString[p1] + "-All" : _pointsToString[p1] + "-" + _pointsToString[p2];
            }
            else
            {
                if (IsDeuce())
                    return "Deuce";
                var s = p1 > p2 ? p1N : p2N;
                
                if (IsAdvantage())
                    return "Advantage " + s;
                else
                    return "Win for " + s;
            }
        }

        private bool IsDeuce() => p1 == p2;

        private bool IsAdvantage() => (p1 - p2) * (p1 - p2) == 1;

        public void WonPoint(string playerName)
        {
            if (playerName == p1N)
                this.p1 += 1;
            else if (playerName == p2N)
                this.p2 += 1;
            else throw new ArgumentException($"{playerName} is unknown", nameof(playerName));
        }

    }
}

