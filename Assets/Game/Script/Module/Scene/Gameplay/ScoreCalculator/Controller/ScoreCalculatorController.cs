using Agate.MVC.Base;
using FlappyInsect.Message;

namespace FlappyInsect.Module.ScoreCalculator
{
    public class ScoreCalculatorController : DataController<ScoreCalculatorController, ScoreCalculatorModel, IScoreCalculatorModel>
    {
        public void OnAddScore(AddScoreMessage message)
        {
            _model.AddScore();
            Publish<UpdateScoreMessage>(new UpdateScoreMessage(_model.Score));
        }
    }
}
