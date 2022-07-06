using Game.Base.MVC;

namespace Game.Module.Score
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
