using Game.Base.MVC;
using Game.Module.Bird;
using Game.Module.Input;

namespace Game.Module.Score
{
    public class ScoreCounterConnector : GameConnector
    {
        private ScoreCounterController _scoreCounter;
        protected override void Connect()
        {
            Subscribe<BirdAddScoreMessage>(_scoreCounter.OnAddScore);
            Subscribe<TapStartMessage>(_scoreCounter.OnTapStart);
        }

        protected override void Disconnect()
        {
            Unsubscribe<BirdAddScoreMessage>(_scoreCounter.OnAddScore);
            Unsubscribe<TapStartMessage>(_scoreCounter.OnTapStart);
        }
    }
}
