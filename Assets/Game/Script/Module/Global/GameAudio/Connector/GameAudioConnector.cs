using Agate.MVC.Base;
using FlappyInsect.Message;

namespace FlappyInsect.Module.GameAudio
{
    public class GameAudioConnector : BaseConnector
    {
        GameAudioController _gameAudio;
        protected override void Connect()
        {
            Subscribe<UpdateBgmConfigMessage>(_gameAudio.OnUpdateBgmConfig);
        }

        protected override void Disconnect()
        {
            Unsubscribe<UpdateBgmConfigMessage>(_gameAudio.OnUpdateBgmConfig);
        }
    }
}
