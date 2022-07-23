using Agate.MVC.Base;

namespace FlappyInsect.Module.GameOver
{
    public interface IGameOverModel : IBaseModel
    {
        public int Score { get; }
        public int HighScore { get; }
        public int Coin { get; }
    }
}
