namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private int _player2Score;
        private int _player1Score;
        private string _player1Name;
        private string _player2Name;

        public TennisGame3(string player1Name, string player2Name)
        {
            _player1Name = player1Name;
            _player2Name = player2Name;
        }

        public string GetScore()
        {
            string score;
            if (scoreIsInGame())
            {
                string[] p = { "Love", "Fifteen", "Thirty", "Forty" };
                score = p[_player1Score];
                return (_player1Score == _player2Score) ? score + "-All" : score + "-" + p[_player2Score];
            }
            
            
            if (_player1Score == _player2Score)
                return "Deuce";
            score = _player1Score > _player2Score ? _player1Name : _player2Name;
            return ((_player1Score - _player2Score) * (_player1Score - _player2Score) == 1) ? "Advantage " + score : "Win for " + score;
            
        }

        private bool scoreIsInGame()
        {
            return (_player1Score < 4 && _player2Score < 4) && (_player1Score + _player2Score < 6);
        }

        public void WonPoint(string playerName)
        {
            if (playerName == _player1Name)
                this._player1Score += 1;
            else
                this._player2Score += 1;
        }

    }
}

