using UnityEngine;

using Game.Base.MVC;
using System.Collections;

namespace Game.Module.SaveData
{
    public class SaveDataController : GameDataController<SaveDataController, SaveDataModel, ISaveDataModel>
    {
        public override IEnumerator Initialize()
        {
            Load();
            return base.Initialize();
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
