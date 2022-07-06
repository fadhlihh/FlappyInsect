using Game.Base.MVC;
using Game.Module.Input;

namespace Game.Module.PlayGame
{
    public class PlayGameConnector : GameConnector
    {
        private PlayGameController _playGameController;
        protected override void Connect()
        {
            Subscribe<StartPlayMessage>(_playGameController.OnStartPlay);
        }

        protected override void Disconnect()
        {
            Unsubscribe<StartPlayMessage>(_playGameController.OnStartPlay);
        }
    }
}
