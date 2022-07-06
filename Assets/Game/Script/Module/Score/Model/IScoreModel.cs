using Game.Base.MVC;

namespace Game.Module.Score
{
    public interface IScoreModel : IGameBaseModel
    {
        public int Score { get; }
    }
}
