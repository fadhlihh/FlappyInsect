using UnityEngine;

using Game.Base.MVC;
using Game.Module.Bird;
using Game.Module.HighScore;

namespace Game.Module.GameOver
{
    public class GameOverPopUpConnector : GameConnector
    {
        private GameOverPopUpController _gameOverPopUp;
        protected override void Connect()
        {
            Subscribe<BirdDeathMessage>(_gameOverPopUp.OnGameOver);
            Subscribe<UpdateHighScoreMessage>(_gameOverPopUp.OnUpdateHighScore);
        }

        protected override void Disconnect()
        {
            Unsubscribe<BirdDeathMessage>(_gameOverPopUp.OnGameOver);
            Unsubscribe<UpdateHighScoreMessage>(_gameOverPopUp.OnUpdateHighScore);
        }
    }
}
