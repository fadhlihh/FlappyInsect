using Game.Base.MVC;

namespace Game.Module.SaveData
{
    public interface ISaveDataModel : IGameBaseModel
    {
        public int HighScoreData { get; }
    }
}
