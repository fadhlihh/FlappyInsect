using FlappyBird.Base.MVC;

namespace FlappyBird.Module.Score
{
    public interface IScoreModel : IGameBaseModel
    {
        public int Score { get; }
    }
}
