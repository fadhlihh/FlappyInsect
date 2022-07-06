using UnityEngine;
using System.Collections;

using Game.Base.MVC;
using Game.Module.SaveData;
using Game.Module.Score;

namespace Game.Module.HighScore
{
    public class HighScoreController : GameDataController<HighScoreController, HighScoreModel, IHighScoreModel>
    {
        private SaveDataController _saveData;

        public override IEnumerator Finalize()
        {
            yield return base.Finalize();
            LoadHighScore();
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

        public void LoadHighScore()
        {
            _model.SetHighScore(_saveData.Model.HighScoreData);
        }

        public void OnUpdateScore(UpdateScoreMessage message)
        {
            CheckHighScore(message.Score);
        }
    }
}
