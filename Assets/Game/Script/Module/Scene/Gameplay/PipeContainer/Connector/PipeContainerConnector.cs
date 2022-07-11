using FlappyBird.Base.MVC;
using FlappyBird.Module.Input;
using FlappyBird.Module.Bird;

namespace FlappyBird.Module.PipeContainer
{
    public class PipeContainerConnector : GameConnector
    {
        private PipeContainerController _pipeContainer;
        protected override void Connect()
        {
            Subscribe<StartPlayMessage>(_pipeContainer.OnStartPlay);
            Subscribe<GameOverMessage>(_pipeContainer.OnGameOver);
        }

        protected override void Disconnect()
        {
            Unsubscribe<StartPlayMessage>(_pipeContainer.OnStartPlay);
            Unsubscribe<GameOverMessage>(_pipeContainer.OnGameOver);
        }
    }
}
