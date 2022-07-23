using Agate.MVC.Base;
using FlappyInsect.Message;

namespace FlappyInsect.Module.ScoreCalculator
{
    public class ScoreCalculatorConnector : BaseConnector
    {
        private ScoreCalculatorController _scoreCalculator;

        protected override void Connect()
        {
            Subscribe<AddScoreMessage>(_scoreCalculator.OnAddScore);
        }

        protected override void Disconnect()
        {
            Unsubscribe<AddScoreMessage>(_scoreCalculator.OnAddScore);
        }
    }
}
