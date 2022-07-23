using Agate.MVC.Base;

namespace FlappyInsect.Module.CoinCalculator
{
    public interface ICoinCalculatorModel : IBaseModel
    {
        public int Coin { get; }
    }
}
