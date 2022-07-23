using Agate.MVC.Base;

namespace FlappyInsect.Module.GameOver
{
    public class GameOverModel : BaseModel, IGameOverModel
    {
        public int Score { get; private set; } = 0;
        public int HighScore { get; private set; } = 0;
        public int Coin { get; private set; } = 0;

        public void SetScore(int score)
        {
            Score = score;
            SetDataAsDirty();
        }

        public void SetHighScore(int highScore)
        {
            HighScore = highScore;
            SetDataAsDirty();
        }
        public void SetCoin(int coin)
        {
            Coin = coin;
            SetDataAsDirty();
        }
    }
}
