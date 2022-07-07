using Game.Base.MVC;
using Game.Module.Bird;
using Game.Module.HighScore;
using Game.Module.Score;

namespace Game.Module.GameOver
{
    public class GameOverConnector : GameConnector
    {
        private GameOverController _gameOver;

        protected override void Connect()
        {
            Subscribe<GameOverMessage>(_gameOver.OnGameOver);
            Subscribe<UpdateHighScoreMessage>(_gameOver.OnUpdateHighScore);
            Subscribe<UpdateScoreMessage>(_gameOver.OnUpdateScore);
        }

        protected override void Disconnect()
        {
            Unsubscribe<GameOverMessage>(_gameOver.OnGameOver);
            Unsubscribe<UpdateHighScoreMessage>(_gameOver.OnUpdateHighScore);
            Unsubscribe<UpdateScoreMessage>(_gameOver.OnUpdateScore);
        }
    }
}
