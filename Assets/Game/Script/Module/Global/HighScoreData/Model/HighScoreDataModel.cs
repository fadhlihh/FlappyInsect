using FlappyBird.Base.MVC;

namespace FlappyBird.Module.HighScoreData
{
    public class HighScoreDataModel : GameBaseModel, IHighScoreDataModel
    {
        public int HighScore { get; private set; } = 0;

        public void SetHighScore(int highScore)
        {
            HighScore = highScore;
            SetDataAsDirty();
        }
    }
}
