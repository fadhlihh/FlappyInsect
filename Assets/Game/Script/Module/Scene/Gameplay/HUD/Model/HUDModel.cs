using Agate.MVC.Base;

namespace FlappyInsect.Module.HUD
{
    public class HUDModel : BaseModel, IHUDModel
    {
        public bool IsPlaying { get; private set; }
        public int HighScore { get; private set; }
        public int TotalCoin { get; private set; }
        public int Score { get; private set; }
        public int Coin { get; private set; }

        public void SetIsPlaying(bool isPlaying)
        {
            IsPlaying = isPlaying;
            SetDataAsDirty();
        }

        public void SetScore(int score)
        {
            Score = score;
            SetDataAsDirty();
        }

        public void SetCoin(int coin)
        {
            Coin = coin;
            SetDataAsDirty();
        }

        public void SetHighScore(int highScore)
        {
            HighScore = highScore;
            SetDataAsDirty();
        }

        public void SetTotalCoin(int totalCoin)
        {
            TotalCoin = totalCoin;
            SetDataAsDirty();
        }
    }
}
