using System.Collections;
using UnityEngine;
using FlappyBird.Base.MVC;

namespace FlappyBird.Module.HighScoreData
{
    public class HighScoreDataController : GameDataController<HighScoreDataController, HighScoreDataModel, IHighScoreDataModel>
    {
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            Load();
        }
        public void Save(int highScore)
        {
            _model.SetHighScore(highScore);
            PlayerPrefs.SetInt("HighScore", _model.HighScore);
            PlayerPrefs.Save();
            Publish<UpdateHighScoreMessage>(new UpdateHighScoreMessage(highScore));
        }
        public void Load()
        {
            _model.SetHighScore(PlayerPrefs.GetInt("HighScore"));
        }

    }
}
