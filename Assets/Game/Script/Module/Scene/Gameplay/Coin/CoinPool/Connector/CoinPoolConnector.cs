using Agate.MVC.Base;
using FlappyInsect.Message;

namespace FlappyInsect.Module.CoinPool
{
    public class CoinPoolConnector : BaseConnector
    {
        private CoinPoolController _coinPool;
        protected override void Connect()
        {
            Subscribe<StartPlayMessage>(_coinPool.OnStartPlay);
            Subscribe<GameOverMessage>(_coinPool.OnGameOver);
        }

        protected override void Disconnect()
        {
            Unsubscribe<StartPlayMessage>(_coinPool.OnStartPlay);
            Unsubscribe<GameOverMessage>(_coinPool.OnGameOver);
        }
    }
}
