namespace Tennis
{
    public class TennisGame2 : ITennisGame
    {
        private int _player1Point;
        private int _player2Point;
        
        

        public string GetScore()
        {
            var score = "";
            var p2res = "";
            var p1res = "";
                
            if (_player1Point == _player2Point && _player1Point < 3)
            {
                if (_player1Point == 0)
                    score = "Love";
                if (_player1Point == 1)
                    score = "Fifteen";
                if (_player1Point == 2)
                    score = "Thirty";
                score += "-All";
            }
            if (_player1Point == _player2Point && _player1Point > 2)
                score = "Deuce";

            if (_player1Point > 0 && _player2Point == 0)
            {
                if (_player1Point == 1)
                    p1res = "Fifteen";
                if (_player1Point == 2)
                    p1res = "Thirty";
                if (_player1Point == 3)
                    p1res = "Forty";

                p2res = "Love";
                score = p1res + "-" + p2res;
            }
            if (_player2Point > 0 && _player1Point == 0)
            {
                if (_player2Point == 1)
                    p2res = "Fifteen";
                if (_player2Point == 2)
                    p2res = "Thirty";
                if (_player2Point == 3)
                    p2res = "Forty";

                p1res = "Love";
                score = p1res + "-" + p2res;
            }

            if (_player1Point > _player2Point && _player1Point < 4)
            {
                if (_player1Point == 2)
                    p1res = "Thirty";
                if (_player1Point == 3)
                    p1res = "Forty";
                if (_player2Point == 1)
                    p2res = "Fifteen";
                if (_player2Point == 2)
                    p2res = "Thirty";
                score = p1res + "-" + p2res;
            }
            if (_player2Point > _player1Point && _player2Point < 4)
            {
                if (_player2Point == 2)
                    p2res = "Thirty";
                if (_player2Point == 3)
                    p2res = "Forty";
                if (_player1Point == 1)
                    p1res = "Fifteen";
                if (_player1Point == 2)
                    p1res = "Thirty";
                score = p1res + "-" + p2res;
            }

            if (_player1Point > _player2Point && _player2Point >= 3)
            {
                score = "Advantage player1";
            }

            if (_player2Point > _player1Point && _player1Point >= 3)
            {
                score = "Advantage player2";
            }

            if (_player1Point >= 4 && _player2Point >= 0 && (_player1Point - _player2Point) >= 2)
            {
                score = "Win for player1";
            }
            if (_player2Point >= 4 && _player1Point >= 0 && (_player2Point - _player1Point) >= 2)
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
            _player1Point++;
        }

        private void P2Score()
        {
            _player2Point++;
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

