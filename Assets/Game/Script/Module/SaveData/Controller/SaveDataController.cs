using System.Collections;
using UnityEngine;
using Game.Base.MVC;

namespace Game.Module.SaveData
{
    public class SaveDataController : GameDataController<SaveDataController, SaveDataModel, ISaveDataModel>
    {
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            Load();
        }

        public void Save(int highScore)
        {
            _model.SetHighScoreData(highScore);
            PlayerPrefs.SetInt("HighScore", _model.HighScoreData);
            PlayerPrefs.Save();
        }

        public void Load()
        {
            _model.SetHighScoreData(PlayerPrefs.GetInt("HighScore"));
        }
    }
}
