using Agate.MVC.Base;

namespace FlappyInsect.Module.ScoreCalculator
{
    public interface IScoreCalculatorModel : IBaseModel
    {
        public int Score { get; }
    }
}
