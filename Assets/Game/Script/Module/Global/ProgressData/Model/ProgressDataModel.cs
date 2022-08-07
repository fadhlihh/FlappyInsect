using Agate.MVC.Base;
using FlappyInsect.Module.InsectsData;

namespace FlappyInsect.Module.ProgressData
{
    public class ProgressDataModel : BaseModel, IProgressDataModel
    {
        public Progress Progress { get; private set; }

        public void SetProgressData(Progress progress)
        {
            Progress = progress;
            SetDataAsDirty();
        }

        public void AddCollectedInsect(InsectData insect)
        {
            Progress.Insects.Add(insect);
            SetDataAsDirty();
        }

        public void SetHighScore(int highScore)
        {
            Progress.HighScore = highScore;
            SetDataAsDirty();
        }

        public void SetCoin(int coin)
        {
            Progress.Coin = coin;
            SetDataAsDirty();
        }

        public void SetSelectedInsect(InsectData insect)
        {
            Progress.SelectedInsect = insect;
            SetDataAsDirty();
        }
    }
}
