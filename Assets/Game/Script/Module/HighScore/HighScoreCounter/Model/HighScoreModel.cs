using UnityEngine;

using Game.Base.MVC;

namespace Game.Module.HighScore
{
    public class HighScoreCounterModel : GameBaseModel, IHighScoreModel
    {
        public int HighScore { get; private set; } = 0;
        public void SetHighScore(int highScore)
        {
            HighScore = highScore;
            SetDataAsDirty();
        }
    }
}
