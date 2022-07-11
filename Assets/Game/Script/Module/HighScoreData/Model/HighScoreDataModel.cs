using Game.Base.MVC;

namespace Game.Module.HighScoreData
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
