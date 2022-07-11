using FlappyBird.Base.MVC;
using FlappyBird.Module.Input;

namespace FlappyBird.Module.Bird
{
    public class BirdMovementConnector : GameConnector
    {
        private BirdMovementController _birdMovement;
        protected override void Connect()
        {
            Subscribe<StartPlayMessage>(_birdMovement.OnStartPlay);
            Subscribe<MoveBirdMessage>(_birdMovement.OnMoveBird);
        }

        protected override void Disconnect()
        {
            Unsubscribe<StartPlayMessage>(_birdMovement.OnStartPlay);
            Unsubscribe<MoveBirdMessage>(_birdMovement.OnMoveBird);
        }
    }
}
