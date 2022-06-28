using System.Collections;

using Game.Base.MVC;
using Game.Module.SaveData;

namespace Game.Module.HighScore
{
    public class HighScoreCounterController : GameDataController<HighScoreCounterController, HighScoreCounterModel, IHighScoreModel>
    {
        private SaveDataController _saveData;

        public override IEnumerator Initialize()
        {
            /// there are bugs if you run this code
            // LoadHighScore();
            return base.Initialize();
        }

        public void CheckHighScore(int score)
        {
            if (score > _model.HighScore)
            {
                UpdateHighScore(score);
                _saveData.Save(_model.HighScore);
            }
        }

        public void UpdateHighScore(int score)
        {
            _model.SetHighScore(score);
            Publish<UpdateHighScoreMessage>(new UpdateHighScoreMessage(score));
        }

        private void LoadHighScore()
        {
            _model.SetHighScore(_saveData.Model.HighScoreData);
        }
    }
}
