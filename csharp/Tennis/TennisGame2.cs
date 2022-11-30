namespace Tennis
{
    public class TennisGame2 : ITennisGame
    {
        private const string LoveString = "Love";
        private const string FifteenString = "Fifteen";
        private const string ThirtyString = "Thirty";
        private const string DashAllString = "-All";
        private const string DeuceString = "Deuce";
        private const string FortyString = "Forty";
        private const string SeperatorString = "-";
        private int _p1point;
        private int _p2point;

        private string _p1Result = "";
        private string _p2Result = "";

        public string GetScore()
        {
            var score = "";
            if (_p1point == _p2point && _p1point < 3)
            {
                if (_p1point == 0)
                    score = LoveString;
                if (_p1point == 1)
                    score = FifteenString;
                if (_p1point == 2)
                    score = ThirtyString;
                score += DashAllString;
            }
            if (_p1point == _p2point && _p1point > 2)
                score = DeuceString;

            if (_p1point > 0 && _p2point == 0)
            {
                if (_p1point == 1)
                    _p1Result = FifteenString;
                if (_p1point == 2)
                    _p1Result = ThirtyString;
                if (_p1point == 3)
                    _p1Result = FortyString;

                _p2Result = LoveString;
                score = _p1Result + SeperatorString + _p2Result;
            }
            if (_p2point > 0 && _p1point == 0)
            {
                if (_p2point == 1)
                    _p2Result = FifteenString;
                if (_p2point == 2)
                    _p2Result = ThirtyString;
                if (_p2point == 3)
                    _p2Result = FortyString;

                _p1Result = LoveString;
                score = _p1Result + SeperatorString + _p2Result;
            }

            if (_p1point > _p2point && _p1point < 4)
            {
                if (_p1point == 2)
                    _p1Result = ThirtyString;
                if (_p1point == 3)
                    _p1Result = FortyString;
                if (_p2point == 1)
                    _p2Result = FifteenString;
                if (_p2point == 2)
                    _p2Result = ThirtyString;
                score = _p1Result + SeperatorString + _p2Result;
            }
            if (_p2point > _p1point && _p2point < 4)
            {
                if (_p2point == 2)
                    _p2Result = ThirtyString;
                if (_p2point == 3)
                    _p2Result = FortyString;
                if (_p1point == 1)
                    _p1Result = FifteenString;
                if (_p1point == 2)
                    _p1Result = ThirtyString;
                score = _p1Result + SeperatorString + _p2Result;
            }

            if (_p1point > _p2point && _p2point >= 3)
            {
                score = "Advantage player1";
            }

            if (_p2point > _p1point && _p1point >= 3)
            {
                score = "Advantage player2";
            }

            if (_p1point >= 4 && _p2point >= 0 && (_p1point - _p2point) >= 2)
            {
                score = "Win for player1";
            }
            if (_p2point >= 4 && _p1point >= 0 && (_p2point - _p1point) >= 2)
            {
                score = "Win for player2";
            }
            return score;
        }
        

        public void AddOnePointToPlayer(string player)
        {
            if (player == "player1")
                _p1point++;
            else
                _p2point++;
        }

    }
}

