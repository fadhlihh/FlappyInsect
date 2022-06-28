using Game.Base.MVC;
using Game.Module.Input;

namespace Game.Module.Bird
{
    public class BirdMovementConnector : GameConnector
    {
        private BirdMovementController _birdMovement;
        protected override void Connect()
        {
            Subscribe<TapStartMessage>(_birdMovement.OnTapStart);
            Subscribe<TapMessage>(_birdMovement.OnMoveBird);
        }

        protected override void Disconnect()
        {
            Unsubscribe<TapStartMessage>(_birdMovement.OnTapStart);
            Unsubscribe<TapMessage>(_birdMovement.OnMoveBird);
        }
    }
}
