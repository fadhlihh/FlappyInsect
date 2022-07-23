using Agate.MVC.Base;

namespace FlappyInsect.Module.CoinCalculator
{
    public class CoinCalculatorModel : BaseModel, ICoinCalculatorModel
    {
        public int Coin { get; private set; }

        public void AddCoin()
        {
            Coin++;
            SetDataAsDirty();
        }
    }
}
