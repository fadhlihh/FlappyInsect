using Game.Base.MVC;
using Game.Module.Input;
using Game.Module.Bird;

namespace Game.Module.Pipe
{
    public class PipeScrollConnector : GameConnector
    {
        private PipeScrollController _pipeScroll;
        protected override void Connect()
        {
            Subscribe<TapStartMessage>(_pipeScroll.OnPlayGame);
            Subscribe<BirdDeathMessage>(_pipeScroll.OnGameOver);
        }

        protected override void Disconnect()
        {
            Unsubscribe<TapStartMessage>(_pipeScroll.OnPlayGame);
            Unsubscribe<BirdDeathMessage>(_pipeScroll.OnGameOver);
        }
    }
}
