using UnityEngine;

using Game.Base.MVC;

using Game.Module.Input;

namespace Game.Module.PlayGame
{
    public class PlayGameConnector : GameConnector
    {
        private PlayGameController _playGameController;
        protected override void Connect()
        {
            Subscribe<TapStartMessage>(_playGameController.OnDisablePlayGameView);
        }

        protected override void Disconnect()
        {
            Unsubscribe<TapStartMessage>(_playGameController.OnDisablePlayGameView);
        }
    }
}
