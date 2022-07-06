using UnityEngine;

using Game.Base.MVC;
using Game.Module.Bird;

namespace Game.Module.Audio
{
    public class GameplayAudioConnector : GameConnector
    {
        private GameplayAudioController _audio;

        protected override void Connect()
        {
            Subscribe<AddScoreMessage>(_audio.OnAddScore);
            Subscribe<GameOverMessage>(_audio.OnGameOver);
        }

        protected override void Disconnect()
        {
            Unsubscribe<AddScoreMessage>(_audio.OnAddScore);
            Unsubscribe<GameOverMessage>(_audio.OnGameOver);
        }
    }
}
