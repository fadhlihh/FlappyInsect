using Agate.MVC.Base;
using Agate.MVC.Core;
using FlappyInsect.Module.CoinCalculator;
using FlappyInsect.Module.CoinPool;

namespace FlappyInsect.Module.Coin
{
    public class CoinController : GroupController<CoinController>
    {
        protected override IController[] GetSubControllers()
        {
            return new IController[]{
                new CoinCalculatorController(),
                new CoinPoolController()
            };
        }
    }
}
