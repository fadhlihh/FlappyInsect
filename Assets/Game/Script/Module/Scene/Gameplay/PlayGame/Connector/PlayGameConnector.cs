using FlappyBird.Base.MVC;
using FlappyBird.Module.Input;

namespace FlappyBird.Module.PlayGame
{
    public class PlayGameConnector : GameConnector
    {
        private PlayGameController _playGame;
        protected override void Connect()
        {
            Subscribe<StartPlayMessage>(_playGame.OnStartPlay);
        }

        protected override void Disconnect()
        {
            Unsubscribe<StartPlayMessage>(_playGame.OnStartPlay);
        }
    }
}
