using UnityEngine;

using Game.Base.MVC;
using Game.Module.Bird;

namespace Game.Module.GameOver
{
    public class GameOverPopUpConnector : GameConnector
    {
        private GameOverPopUpController _gameOverPopUp;
        protected override void Connect()
        {
            Subscribe<BirdDeathMessage>(_gameOverPopUp.OnGameOver);
        }

        protected override void Disconnect()
        {
            Unsubscribe<BirdDeathMessage>(_gameOverPopUp.OnGameOver);
        }
    }
}
