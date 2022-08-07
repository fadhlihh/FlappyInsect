using Agate.MVC.Base;
using FlappyInsect.Message;

namespace FlappyInsect.Module.CoinCalculator
{
    public class CoinCalculatorController : DataController<CoinCalculatorController, CoinCalculatorModel, ICoinCalculatorModel>
    {
        public void OnAddCoin()
        {
            _model.AddCoin();
            Publish<UpdateCoinMessage>(new UpdateCoinMessage(_model.Coin));
        }
    }
}
