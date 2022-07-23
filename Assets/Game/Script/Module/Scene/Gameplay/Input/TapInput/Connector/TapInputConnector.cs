using Agate.MVC.Base;
using FlappyInsect.Message;

namespace FlappyInsect.Module.Input
{
    public class TapInputConnector : BaseConnector
    {
        private TapInputController _tapInput;
        protected override void Connect()
        {
            Subscribe<GameOverMessage>(_tapInput.OnGameOver);
        }

        protected override void Disconnect()
        {
            Unsubscribe<GameOverMessage>(_tapInput.OnGameOver);
        }
    }
}
