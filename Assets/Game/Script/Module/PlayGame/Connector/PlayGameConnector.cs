using Game.Base.MVC;
using Game.Module.Input;

namespace Game.Module.PlayGame
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
