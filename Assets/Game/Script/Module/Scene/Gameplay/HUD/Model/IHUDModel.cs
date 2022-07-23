using Agate.MVC.Base;

namespace FlappyInsect.Module.HUD
{
    public interface IHUDModel : IBaseModel
    {
        public bool IsPlaying { get; }
        public int HighScore { get; }
        public int TotalCoin { get; }
        public int Score { get; }
        public int Coin { get; }
    }
}
