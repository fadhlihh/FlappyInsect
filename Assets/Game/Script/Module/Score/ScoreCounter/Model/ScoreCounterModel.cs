using Game.Base.MVC;

namespace Game.Module.Score
{
    public class ScoreCounterModel : GameBaseModel, IScoreCounterModel
    {
        public int Score { get; private set; } = 0;
        public void AddScore()
        {
            Score++;
            SetDataAsDirty();
        }
    }
}
