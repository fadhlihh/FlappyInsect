using Agate.MVC.Base;
using FlappyInsect.Message;

namespace FlappyInsect.Module.ObstaclePool
{
    public class ObstaclePoolConnector : BaseConnector
    {
        private ObstaclePoolController _obstaclePool;

        protected override void Connect()
        {
            Subscribe<StartPlayMessage>(_obstaclePool.OnStartPlay);
            Subscribe<GameOverMessage>(_obstaclePool.OnGameOver);
        }

        protected override void Disconnect()
        {
            Unsubscribe<StartPlayMessage>(_obstaclePool.OnStartPlay);
            Unsubscribe<GameOverMessage>(_obstaclePool.OnGameOver);
        }
    }
}
