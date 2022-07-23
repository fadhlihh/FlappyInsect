using System.Collections;
using System.IO;
using UnityEngine;
using Agate.MVC.Base;
using FlappyInsect.Module.InsectsData;

namespace FlappyInsect.Module.ProgressData
{
    public class ProgressDataController : DataController<ProgressDataController, ProgressDataModel, IProgressDataModel>
    {
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            Load();
        }

        public void SetNewHighScore(int highScore)
        {
            _model.SetHighScore(highScore);
        }

        public void SetTotalCoin(int coin)
        {
            _model.SetCoin(coin);
        }

        public void ChangeSelectedInsect(InsectData selectedInsect)
        {
            _model.ChangeSelectedInsect(selectedInsect);
        }

        public void SaveProgress()
        {
            Save();
        }

        private void Load()
        {
            string directory = Path.Combine(Application.persistentDataPath, "Save");
            string path = Path.Combine(directory, "Progress.json");
            if (File.Exists(path))
            {
                string progressFile = File.ReadAllText(path);
                Progress progress = JsonUtility.FromJson<Progress>(progressFile);
                _model.SetProgressData(progress);
            }
            else
            {
                Directory.CreateDirectory(directory);
                InitProgress();
            }
        }

        private void InitProgress()
        {
            TextAsset initProgressFile = Resources.Load<TextAsset>(@"Data/Progress/InitialProgress");
            Progress progress = JsonUtility.FromJson<Progress>(initProgressFile.text);
            _model.SetProgressData(progress);
            Save();
        }

        private void Save()
        {
            string path = $"{Application.persistentDataPath}/Save/Progress.json";
            string progressData = JsonUtility.ToJson(_model.Progress);
            File.WriteAllText(path, progressData);
        }
    }
}
