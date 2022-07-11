using Game.Base.MVC;

namespace Game.Module.HighScoreData
{
    public interface IHighScoreDataModel : IGameBaseModel
    {
        public int HighScore { get; }
    }
}
