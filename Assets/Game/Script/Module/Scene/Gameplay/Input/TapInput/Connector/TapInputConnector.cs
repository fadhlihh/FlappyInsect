using FlappyBird.Base.MVC;
using FlappyBird.Module.Bird;

namespace FlappyBird.Module.Input
{
    public class TapInputConnector : GameConnector
    {
        private TapInputController _tapInput;
        protected override void Connect()
        {
            Subscribe<GameOverMessage>(_tapInput.OnGameOver);
        }

        protected override void Disconnect()
        {
            Subscribe<GameOverMessage>(_tapInput.OnGameOver);
        }
    }
}
