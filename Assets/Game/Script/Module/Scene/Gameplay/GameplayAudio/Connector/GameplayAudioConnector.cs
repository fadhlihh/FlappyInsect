using Agate.MVC.Base;
using FlappyInsect.Message;

namespace FlappyInsect.Module.GameplayAudio
{
    public class GameplayAudioConnector : BaseConnector
    {
        private GameplayAudioController _audio;

        protected override void Connect()
        {
            Subscribe<UpdateSfxConfigMessage>(_audio.OnUpdateSfxConfig);
            Subscribe<MoveInsectMessage>(_audio.OnMoveInsect);
            Subscribe<AddScoreMessage>(_audio.OnAddScore);
            Subscribe<AddCoinMessage>(_audio.OnAddCoin);
            Subscribe<GameOverMessage>(_audio.OnGameOver);
        }

        protected override void Disconnect()
        {
            Unsubscribe<UpdateSfxConfigMessage>(_audio.OnUpdateSfxConfig);
            Unsubscribe<MoveInsectMessage>(_audio.OnMoveInsect);
            Unsubscribe<AddScoreMessage>(_audio.OnAddScore);
            Unsubscribe<AddCoinMessage>(_audio.OnAddCoin);
            Unsubscribe<GameOverMessage>(_audio.OnGameOver);
        }
    }
}
