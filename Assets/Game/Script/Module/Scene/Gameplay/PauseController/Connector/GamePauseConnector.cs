using Agate.MVC.Base;
using FlappyInsect.Message;

namespace FlappyInsect.Module.GamePause
{
    public class GamePauseConnector : BaseConnector
    {
        private GamePauseController _gamePause;

        protected override void Connect()
        {
            Subscribe<ShowGamePauseMessage>(_gamePause.OnShowGamePause);
        }

        protected override void Disconnect()
        {
            Unsubscribe<ShowGamePauseMessage>(_gamePause.OnShowGamePause);
        }
    }
}
