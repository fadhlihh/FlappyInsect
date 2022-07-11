using FlappyBird.Base.MVC;

namespace FlappyBird.Module.Score
{
    public class ScoreModel : GameBaseModel, IScoreModel
    {
        public int Score { get; private set; } = 0;
        public void AddScore()
        {
            Score++;
            SetDataAsDirty();
        }
    }
}
