using FlappyBird.Base.MVC;
using FlappyBird.Module.Bird;
using FlappyBird.Module.HighScoreData;
using FlappyBird.Module.Score;

namespace FlappyBird.Module.GameOver
{
    public class GameOverConnector : GameConnector
    {
        private GameOverController _gameOver;

        protected override void Connect()
        {
            Subscribe<GameOverMessage>(_gameOver.OnGameOver);
            Subscribe<ShowCalcScoreMessage>(_gameOver.OnShowCalcScore);
        }

        protected override void Disconnect()
        {
            Unsubscribe<GameOverMessage>(_gameOver.OnGameOver);
            Unsubscribe<ShowCalcScoreMessage>(_gameOver.OnShowCalcScore);
        }
    }
}
