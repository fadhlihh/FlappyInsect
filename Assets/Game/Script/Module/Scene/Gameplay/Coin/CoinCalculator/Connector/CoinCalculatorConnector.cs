using Agate.MVC.Base;
using FlappyInsect.Message;

namespace FlappyInsect.Module.CoinCalculator
{
    public class CoinCalculatorConnector : BaseConnector
    {
        private CoinCalculatorController _coinCalculator;

        protected override void Connect()
        {
            Subscribe<AddCoinMessage>(_coinCalculator.OnAddCoin);
        }

        protected override void Disconnect()
        {
            Unsubscribe<AddCoinMessage>(_coinCalculator.OnAddCoin);
        }
    }
}
