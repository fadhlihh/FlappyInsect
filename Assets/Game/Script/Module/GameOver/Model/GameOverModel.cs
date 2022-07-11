using FlappyBird.Base.MVC;

namespace FlappyBird.Module.GameOver
{
    public class GameOverModel : GameBaseModel, IGameOverModel
    {
        public int Score { get; private set; } = 0;
        public int HighScore { get; private set; } = 0;

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
    }
}
