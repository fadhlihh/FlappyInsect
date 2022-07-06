using Game.Base.MVC;
using Game.Module.Bird;
using Game.Module.HighScore;
using Game.Module.Score;

namespace Game.Module.GameOver
{
    public class GameOverConnector : GameConnector
    {
        private GameOverController _gameOverPopUp;

        protected override void Connect()
        {
            Subscribe<GameOverMessage>(_gameOverPopUp.OnGameOver);
            Subscribe<UpdateHighScoreMessage>(_gameOverPopUp.OnUpdateHighScore);
            Subscribe<UpdateScoreMessage>(_gameOverPopUp.OnUpdateScore);
        }

        protected override void Disconnect()
        {
            Unsubscribe<GameOverMessage>(_gameOverPopUp.OnGameOver);
            Unsubscribe<UpdateHighScoreMessage>(_gameOverPopUp.OnUpdateHighScore);
            Unsubscribe<UpdateScoreMessage>(_gameOverPopUp.OnUpdateScore);
        }
    }
}
