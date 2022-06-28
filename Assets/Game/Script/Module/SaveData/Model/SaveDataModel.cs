using Game.Base.MVC;

namespace Game.Module.SaveData
{
    public class SaveDataModel : GameBaseModel, ISaveDataModel
    {
        public int HighScoreData { get; private set; } = 0;

        public void SetHighScoreData(int highScore)
        {
            HighScoreData = highScore;
            SetDataAsDirty();
        }
    }
}
