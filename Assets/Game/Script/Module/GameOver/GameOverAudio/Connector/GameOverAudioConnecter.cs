using UnityEngine;

using Game.Base.MVC;
using Game.Module.Bird;

namespace Game.Module.GameOver
{
    public class GameOverAudioConnecter : GameConnector
    {
        private GameOverAudioController _gameOverAudio;
        protected override void Connect()
        {
            Subscribe<BirdDeathMessage>(_gameOverAudio.OnGameOver);
        }

        protected override void Disconnect()
        {
            Unsubscribe<BirdDeathMessage>(_gameOverAudio.OnGameOver);
        }
    }
}
