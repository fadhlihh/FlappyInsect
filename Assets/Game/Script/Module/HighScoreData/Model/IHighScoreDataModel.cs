using FlappyBird.Base.MVC;

namespace FlappyBird.Module.HighScoreData
{
    public interface IHighScoreDataModel : IGameBaseModel
    {
        public int HighScore { get; }
    }
}
