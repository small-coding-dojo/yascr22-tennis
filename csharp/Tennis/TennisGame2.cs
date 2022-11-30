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
        private int p1point;
        private int p2point;

        private string p1res = "";
        private string p2res = "";
        private string player1Name;
        private string player2Name;

        public TennisGame2(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            p1point = 0;
            this.player2Name = player2Name;
        }

        public string GetScore()
        {
            var score = "";
            if (p1point == p2point && p1point < 3)
            {
                if (p1point == 0)
                    score = LoveString;
                if (p1point == 1)
                    score = FifteenString;
                if (p1point == 2)
                    score = ThirtyString;
                score += DashAllString;
            }
            if (p1point == p2point && p1point > 2)
                score = DeuceString;

            if (p1point > 0 && p2point == 0)
            {
                if (p1point == 1)
                    p1res = FifteenString;
                if (p1point == 2)
                    p1res = ThirtyString;
                if (p1point == 3)
                    p1res = FortyString;

                p2res = LoveString;
                score = p1res + SeperatorString + p2res;
            }
            if (p2point > 0 && p1point == 0)
            {
                if (p2point == 1)
                    p2res = FifteenString;
                if (p2point == 2)
                    p2res = ThirtyString;
                if (p2point == 3)
                    p2res = FortyString;

                p1res = LoveString;
                score = p1res + SeperatorString + p2res;
            }

            if (p1point > p2point && p1point < 4)
            {
                if (p1point == 2)
                    p1res = ThirtyString;
                if (p1point == 3)
                    p1res = FortyString;
                if (p2point == 1)
                    p2res = FifteenString;
                if (p2point == 2)
                    p2res = ThirtyString;
                score = p1res + SeperatorString + p2res;
            }
            if (p2point > p1point && p2point < 4)
            {
                if (p2point == 2)
                    p2res = ThirtyString;
                if (p2point == 3)
                    p2res = FortyString;
                if (p1point == 1)
                    p1res = FifteenString;
                if (p1point == 2)
                    p1res = ThirtyString;
                score = p1res + SeperatorString + p2res;
            }

            if (p1point > p2point && p2point >= 3)
            {
                score = "Advantage player1";
            }

            if (p2point > p1point && p1point >= 3)
            {
                score = "Advantage player2";
            }

            if (p1point >= 4 && p2point >= 0 && (p1point - p2point) >= 2)
            {
                score = "Win for player1";
            }
            if (p2point >= 4 && p1point >= 0 && (p2point - p1point) >= 2)
            {
                score = "Win for player2";
            }
            return score;
        }

        public void SetP1Score(int number)
        {
            for (int i = 0; i < number; i++)
            {
                P1Score();
            }
        }

        public void SetP2Score(int number)
        {
            for (var i = 0; i < number; i++)
            {
                P2Score();
            }
        }

        private void P1Score()
        {
            p1point++;
        }

        private void P2Score()
        {
            p2point++;
        }

        public void WonPoint(string player)
        {
            if (player == "player1")
                P1Score();
            else
                P2Score();
        }

    }
}

